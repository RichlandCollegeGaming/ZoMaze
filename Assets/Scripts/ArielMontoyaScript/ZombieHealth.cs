using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieHealth : MonoBehaviour
{
    public int zombiemaxHealth = 100;
    public int zombiecurrentHealth;
    public int zombiedamageAmount = 20; // Damage amount dealt by the bullet
    public GameObject BloodPrefab;
    public Transform zombiePoint;

    void Start()
    {
        zombiecurrentHealth = zombiemaxHealth;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        // Check if the entering collider is a bullet
        if (other.gameObject.CompareTag("Bullet"))
        {
            // Deal damage to the enemy
            ZombieTakeDamage(zombiedamageAmount);

            // Destroy the bullet
            Destroy(other.gameObject);
        }
    }

    void ZombieTakeDamage(int damage)
    {
        zombiecurrentHealth -= damage;
        if (zombiecurrentHealth <= 0)
        {
            zombiecurrentHealth = 0;
            ZombieDie();
        }
    }

    void ZombieDie()
    {
        // Enemy death logic, such as playing death animation, awarding points, etc.
        Destroy(gameObject);
        { 
            GameObject Blood = Instantiate(BloodPrefab, zombiePoint.position, zombiePoint.rotation);
            Destroy(gameObject);
        }
    }
}