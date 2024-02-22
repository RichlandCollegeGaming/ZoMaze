using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointTowardsMouse : MonoBehaviour
{
    void Update()
    {
        PointObjectTowardsMouse();
    }

    void PointObjectTowardsMouse()
    {
        // Get the mouse position in the world space
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            // Calculate the direction from the object to the mouse position
            Vector3 lookDir = hit.point - transform.position;

            // Calculate the rotation to look towards the mouse
            Quaternion rotation = Quaternion.LookRotation(lookDir, Vector3.up);

            // Apply the rotation to the object
            transform.rotation = rotation;
        }
    }
}


