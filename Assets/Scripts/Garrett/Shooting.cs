using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public float fireForce = 20f;
    public int currentClip, maxClipSize = 10, currentAmmo, maxAmmoSize = 100, ammoAmount;
    public float fireRate = 1f;
    public float shootDelay = 1000f; // Delay after shooting before next shot is allowed
    private float nextFireTime = 1000f;
    private bool canShoot = true; // Flag to check if the gun can shoot

    public float bulletForce = 1000f;

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
        Shoot();
        yield return new WaitForSeconds(shootDelay);
        canShoot = true;
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
    }

    public void Fire()
    {
        if (Time.time >= nextFireTime && currentClip > 0)
        {
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);
            bullet.GetComponent<Rigidbody2D>().AddForce(firePoint.up * fireForce, ForceMode2D.Impulse);
            currentClip--;
            nextFireTime = Time.time + 1f / fireRate;
            nextFireTime += shootDelay;
        }
    }

    public void Reload()
    {
        int reloadAmount = maxClipSize - currentClip; // how many bullets to refill clip
        reloadAmount = Mathf.Min(reloadAmount, currentAmmo); // Reload with available ammo
        currentClip += reloadAmount;
        currentAmmo -= reloadAmount;
    }

    public void AddAmmo(int newAmount)
    {
        currentAmmo += newAmount;
        if (currentAmmo > maxAmmoSize)
        {
            currentAmmo = maxAmmoSize;
        }
    }
}
