using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;

public class SpawnOnSceneLoad : MonoBehaviour
{
    public GameObject prefabToSpawn;

    void Start()
    {
        // Spawn the prefab when the scene loads
        Instantiate(prefabToSpawn, transform.position, Quaternion.identity);
    }
}
