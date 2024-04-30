using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupHandler : MonoBehaviour
{
    // Reference to the objects on the player to toggle for pistol pickup
    public GameObject[] pistolObjectsToToggleOff;
    public GameObject pistolObjectToToggleOn;

    // Reference to the objects on the player to toggle for MG pickup
    public GameObject[] mgObjectsToToggleOff;
    public GameObject mgObjectToToggleOn;

    // Reference to the objects on the player to toggle for shotgun pickup
    public GameObject[] shotgunObjectsToToggleOff;
    public GameObject shotgunObjectToToggleOn;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Pistol"))
        {
            // Toggle off objects for pistol pickup
            ToggleObjects(pistolObjectsToToggleOff, pistolObjectToToggleOn);
        }
        else if (other.CompareTag("MG"))
        {
            // Toggle off objects for MG pickup
            ToggleObjects(mgObjectsToToggleOff, mgObjectToToggleOn);
        }
        else if (other.CompareTag("Shotgun"))
        {
            // Toggle off objects for shotgun pickup
            ToggleObjects(shotgunObjectsToToggleOff, shotgunObjectToToggleOn);
        }
    }

    private void ToggleObjects(GameObject[] objectsToToggleOff, GameObject objectToToggleOn)
    {
        // Toggle off objects
        foreach (GameObject obj in objectsToToggleOff)
        {
            obj.SetActive(false);
        }

        // Activate object
        objectToToggleOn.SetActive(true);

        // Set the boolean variable to true on the other script

        Shooting.canShoot = true;

        /*

        for (int i = 0; i < objectToToggleOn.childCount; i++)
        {
            objectToToggleOn.GetChild(i).canShoot = true;
        }
        objectToToggleOn.SetActive(true);

        */


    }
}

