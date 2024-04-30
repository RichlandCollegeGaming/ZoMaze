using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleObjectsPlayer : MonoBehaviour
{
    public GameObject objectToToggleOn;
    public GameObject[] objectsToToggleOff;

    private bool playerHasCollided = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the collider is the player
        if (other.CompareTag("Player"))
        {
            // Toggle the object on
            objectToToggleOn.SetActive(!objectToToggleOn.activeSelf);

            // Toggle off other objects
            foreach (GameObject obj in objectsToToggleOff)
            {
                obj.SetActive(false);
            }

            // Destroy the object
            Destroy(gameObject);

            // Set collision flag
            playerHasCollided = true;
        }
    }

    // Reset collision flag on exit
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerHasCollided = false;
        }
    }

    // Reset objects on collision exit
    private void Update()
    {
        if (playerHasCollided && Input.GetKeyDown(KeyCode.Space)) // Reset objects on space key
        {
            // Toggle the object on
            objectToToggleOn.SetActive(true);

            // Toggle on other objects
            foreach (GameObject obj in objectsToToggleOff)
            {
                obj.SetActive(true);
            }

            // Destroy the object
            Destroy(gameObject);

            // Reset collision flag
            playerHasCollided = false;
        }
    }
}
