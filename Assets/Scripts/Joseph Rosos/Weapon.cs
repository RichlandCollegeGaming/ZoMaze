using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon" , menuName = "Weapon")]
public class PlayerWeapon : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform Firepoint;
    public float fireForce = 20f;
    public Sprite currentWeaponSpr;
    public int currentClip, maxClipSize = 10, currentAmmo, maxAmmoSize = 100, ammoAmount;
    

    public float fireRate = 1;
     public void Fire()

     {
        if (currentClip > 0)
        {


            GameObject Bullet = Instantiate(bulletPrefab, GameObject.Find("FirePoint").transform.position, Quaternion.identity);
            Bullet.GetComponent<Rigidbody2D>().AddForce(Firepoint.up * fireForce, ForceMode2D.Impulse);
            currentClip--;
        }
     }
    public void Reload()
    {
        int reloadAmount = maxClipSize - currentClip; // how mnay bullets to refill clip
        reloadAmount = (currentAmmo - reloadAmount >= 0 ? reloadAmount : currentAmmo);
        currentClip += reloadAmount;
        currentAmmo -= reloadAmount;
    }
   
    public void AddAmmo(int newAmount)
    {
        currentAmmo += ammoAmount;
        if(currentAmmo > maxAmmoSize)
        {
            currentAmmo = maxAmmoSize;
        }

    }
}
