using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouseXY : MonoBehaviour
{
    public float followSpeed = 5f;

    void Update()
    {
        FollowMouse();
    }

    void FollowMouse()
    {
        // Get the mouse position in screen space
        Vector3 mousePosScreen = Input.mousePosition;

        // Set a constant Z-coordinate to define the distance from the camera
        mousePosScreen.z = transform.position.z - Camera.main.transform.position.z;

        // Convert the mouse position to world space
        Vector3 mousePosWorld = Camera.main.ScreenToWorldPoint(mousePosScreen);

        // Move the object towards the mouse position only on the X and Y axes
        transform.position = Vector3.Lerp(transform.position, new Vector3(mousePosWorld.x, mousePosWorld.y, transform.position.z), followSpeed * Time.deltaTime);
    }
}
