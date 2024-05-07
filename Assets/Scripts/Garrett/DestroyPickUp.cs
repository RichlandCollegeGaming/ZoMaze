using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPickUp : MonoBehaviour
{

    public GameObject SoundPrefab;
    public Transform PickUpPoint;
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the collider is the player
        if (other.CompareTag("Player"))
        {
            GameObject Audio = Instantiate(SoundPrefab, PickUpPoint.position, PickUpPoint.rotation);
            Destroy(gameObject);
        }
    }
}
