using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Enemy : MonoBehaviour
{
    public int damageAmount = 20;
    public int maxHealth = 100;
    private int currentHealth;
    public int enemydamageAmount = 20; // Damage amount dealt by the bullet
    public Transform target;

    private void GetTarget()
    {
        if (GameObject.FindGameObjectWithTag("Player"))
        {
            target = GameObject.FindGameObjectWithTag("Player").transform;
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Health playerHealth = other.gameObject.GetComponent<Health>();
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(enemydamageAmount);
            }
        }
    }

    void Start()
    {
        currentHealth = maxHealth;
    }

    void OnTriggerEnter(Collider other)
    {
        // Check if the entering collider is a bullet
        if (other.CompareTag("Bullet"))
        {
            // Deal damage to the enemy
            TakeDamage(damageAmount);

            // Destroy the bullet
            Destroy(other.gameObject);
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            currentHealth = 0;
            Die();
        }
    }

    void Die()
    {
        // Enemy death logic, such as playing death animation, awarding points, etc.
        Destroy(gameObject);
    }
}

