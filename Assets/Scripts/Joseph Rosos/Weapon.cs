using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapon : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform Firepoint;
    public float fireForce = 20f;

    public void Fire()
    {
        GameObject Bullet = Instantiate(bulletPrefab, Firepoint.position, Firepoint.rotation);
        Bullet.GetComponent<Rigidbody2D>().AddForce(Firepoint.up * fireForce, ForceMode2D.Impulse);
    }

}
