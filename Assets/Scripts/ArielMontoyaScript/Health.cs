using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public Text healthText;

    void Start()
    {
        currentHealth = maxHealth;
        UpdateHealthUI();
    }

    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;
        if (currentHealth <= 0)
        {
            currentHealth = 0;
            Debug.Log("Player died!");
            // You can add more functionality here, like respawning the player.
        }
        UpdateHealthUI();
    }

    void UpdateHealthUI()
    {
        healthText.text = "Health: " + currentHealth;
    }
}