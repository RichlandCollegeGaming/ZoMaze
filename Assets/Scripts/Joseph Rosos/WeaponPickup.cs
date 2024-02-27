using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpController : MonoBehaviour
{
    public Weapon weapon;
    
    
    private void OnTriggerEnter2D(Collider2D target)
    {
        if(target.tag == "Player")
        {
           // target.GetComponent<PlayerrController>(). Weapon = Weapon;
           // target.transform.GetChild(1).GetComponent<SpriteRenderer>().sprite = Weapon.currentWeaponSpr;
            Destroy(gameObject);
        }
    }
}
