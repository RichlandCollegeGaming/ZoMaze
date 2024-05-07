using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float rotateSpeedX = 50f;
    public float rotateSpeedY = 50f;
    public float rotateSpeedZ = 50f;

    void Update()
    {
        // Rotate the object continuously
        float rotateX = rotateSpeedX * Time.deltaTime;
        float rotateY = rotateSpeedY * Time.deltaTime;
        float rotateZ = rotateSpeedZ * Time.deltaTime;

        transform.Rotate(Vector3.right, rotateX);
        transform.Rotate(Vector3.up, rotateY);
        transform.Rotate(Vector3.forward, rotateZ);
    }
}
