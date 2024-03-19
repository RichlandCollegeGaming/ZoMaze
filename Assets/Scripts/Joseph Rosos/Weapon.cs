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
    

    public float fireRate = 1;
     public void Fire()
     {
    GameObject Bullet = Instantiate(bulletPrefab, GameObject.Find("FirePoint").transform.position, Quaternion.identity);
     Bullet.GetComponent<Rigidbody2D>().AddForce(Firepoint.up * fireForce, ForceMode2D.Impulse);
     }

   
}
