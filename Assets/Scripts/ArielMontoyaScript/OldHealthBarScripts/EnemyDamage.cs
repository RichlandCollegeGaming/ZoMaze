using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    // The amount of damage that the enemy will deal to the player 
    public int damageAmount = 1;

    // A timer for controlling the delay between when the player can take damage again 
    private float damageTimer = 0;

    // The delay between when the player can take damage again 
    public float damageDelay = 1;

    // Update is called once per frame 
    void Update()
    {
        // Update the damage timer 
        damageTimer -= Time.deltaTime;
    }

    // Called when a collision is detected 
    void OnCollisionEnter(Collision collision)
    {
        // Check if the collider that has collided with the enemy is the player 
        if (collision.collider.tag == "Player")
        {
            // Check if the player is currently able to take damage (i.e. the damage timer is less than or equal to zero) 
            if (damageTimer <= 0)
            {
                // Subtract the damage amount from the player's health 
                PlayerHealth playerHealth = collision.collider.GetComponent<PlayerHealth>();
                playerHealth.PlayerTakeDamage(damageAmount);

                // Reset the damage timer 
                damageTimer = damageDelay;
            }
        }
    }
}