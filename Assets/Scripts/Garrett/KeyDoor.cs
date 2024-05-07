using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyDoor : MonoBehaviour
{
    [SerializeField] private Key.KeyType keyType;
    public GameObject SoundPrefab;
    public Transform PickUpPoint;


    public Key.KeyType GetKeyType()
    {
        return keyType;
    }

    public void OpenDoor()
    {
        GameObject Audio = Instantiate(SoundPrefab, PickUpPoint.position, PickUpPoint.rotation);
        gameObject.SetActive(false);
    }









}
