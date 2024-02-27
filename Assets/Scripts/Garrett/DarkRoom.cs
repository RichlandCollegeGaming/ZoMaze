using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DarkRoom : MonoBehaviour
{

    public Transform BlackRoom;

    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gameObject.SetActive(gameObject.activeSelf);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gameObject.SetActive(!gameObject.activeSelf);
        }
    }
}
