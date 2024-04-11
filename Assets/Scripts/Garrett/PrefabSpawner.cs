using UnityEngine;
using System.Collections;

public class PrefabSpawner : MonoBehaviour
{
    public GameObject[] prefabs; // Array of prefabs to instantiate
    public float spawnInterval = 4f; // Time between each instantiation
    private float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;

        // Check if it's time to spawn a new prefab
        if (timer >= spawnInterval)
        {
            // Reset timer
            timer = 0f;

            // Instantiate a random prefab from the array
            Instantiate(prefabs[Random.Range(0, prefabs.Length)], transform.position, Quaternion.identity);
        }
    }
}
