using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateUpDown : MonoBehaviour
{
    void Update()
    {
        RotateToMouse();
    }

    void RotateToMouse()
    {
        // Get the mouse position in screen space
        Vector3 mousePosScreen = Input.mousePosition;

        // Set a constant Z-coordinate to define the distance from the camera
        mousePosScreen.z = transform.position.z - Camera.main.transform.position.z;

        // Convert the mouse position to world space
        Vector3 mousePosWorld = Camera.main.ScreenToWorldPoint(mousePosScreen);

        // Calculate the direction from the object to the mouse position
        Vector3 lookDir = mousePosWorld - transform.position;

        // Calculate the rotation angle based on the direction
        float angleZ = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;

        // Set the object's Z rotation to face the mouse
        transform.rotation = Quaternion.Euler(0f, 0f, angleZ);
    }
}


