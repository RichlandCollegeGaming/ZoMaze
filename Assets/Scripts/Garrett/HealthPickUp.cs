using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickUp : MonoBehaviour
{
    public int enemydamageAmount = -20;
    public GameObject SoundPrefab;
    public Transform PickUpPoint;



    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Health playerHealth = other.gameObject.GetComponent<Health>();
            if (playerHealth != null)
            {
                GameObject Audio = Instantiate(SoundPrefab, PickUpPoint.position, PickUpPoint.rotation);
                playerHealth.TakeDamage(enemydamageAmount);
                Destroy(gameObject);
            }
        }
    }
   



}
