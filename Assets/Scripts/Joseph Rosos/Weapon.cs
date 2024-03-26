using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon" , menuName = "Weapon")]
public class PlayerWeapon : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float fireForce = 20f;
    public int currentClip, maxClipSize = 10, currentAmmo, maxAmmoSize = 100, ammoAmount;
    public float fireRate = 1f;
    public float shootDelay = 0.2f; // Delay after shooting before next shot is allowed
    private float nextFireTime = 0f;

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
