using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPickUp : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the collider is the player
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
