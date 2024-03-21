using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffOnContact : MonoBehaviour
{
    private bool playerInRange = false;
    public GameObject objectToToggle;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
            ToggleObject();
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
            ToggleObject();
        }
    }

    private void ToggleObject()
    {
        if (objectToToggle != null)
        {
            objectToToggle.SetActive(!playerInRange);
        }
    }
}


