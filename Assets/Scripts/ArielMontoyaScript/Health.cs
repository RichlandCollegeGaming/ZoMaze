using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public Text healthText;
    [SerializeField] private GameObject WholePlayer;

     void Start()
    {
        currentHealth = maxHealth;
        UpdateHealthUI();
    }

    // Method to heal the player
    public void Heal(int healAmount)
    {
        currentHealth += healAmount;
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
        UpdateHealthUI();
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            currentHealth = 0;
            Die();
        }
        UpdateHealthUI();
    }

    void UpdateHealthUI()
    {
        healthText.text = "Health: " + currentHealth;
    }

    void Die()
    {
        // Load a scene named "GameOver" when the player dies
        Destroy(WholePlayer);
        SceneManager.LoadScene("DeathScreen");
    }
}
