using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform[] firePoints; // Array of fire points
    public GameObject bulletPrefab;
    public float fireForce = 20f;
    //public int currentClip, maxClipSize = 10, currentAmmo, maxAmmoSize = 100, ammoAmount;
    public float shootDelay = 0.5f; // Short delay after shooting before next shot is allowed
    public static bool canShoot = true; // Flag to check if the gun can shoot
    public AudioClip shootSound;

    public float bulletForce = 1000f;

    private AudioSource audioSource; // Reference to AudioSource component

    void Start()
    {
        audioSource = GetComponent<AudioSource>(); // Get AudioSource component
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && canShoot)
        {
            StartCoroutine(ShootWithDelay());
        }
    }

    IEnumerator ShootWithDelay()
    {
        canShoot = false;
        foreach (Transform firePoint in firePoints)
        {
            Shoot(firePoint); // Call Shoot for each fire point
        }
        yield return new WaitForSeconds(shootDelay);
        canShoot = true;
    }

    void Shoot(Transform firePoint)
    {
        // Instantiate bullet
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);

        // Play shoot sound
        if (audioSource != null && shootSound != null)
        {
            audioSource.PlayOneShot(shootSound);
        }
    }

}

