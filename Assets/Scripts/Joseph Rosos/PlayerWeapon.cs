using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[CreateAssetMenu (fileName = "New Weapon", menuName = "Weapon")]

public class Weapon : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform Firepoint;
    public float fireForce = 20f;

    public void Fire()
    {
        GameObject bullet = Instantiate(bulletPrefab, Firepoint.position, Firepoint.rotation);
        bullet.GetComponent<Rigidbody2D>().AddForce(Firepoint.up * fireForce, ForceMode2D.Impulse);
    }

}
