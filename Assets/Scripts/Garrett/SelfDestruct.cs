using UnityEngine;

public class SelfDestruct : MonoBehaviour
{
    void Start()
    {
        // Invoke the method to self-destruct after 3 seconds
        Invoke("DestroySelf", 3f);
    }

    void DestroySelf()
    {
        // Destroy the GameObject this script is attached to
        Destroy(gameObject);
    }
}
