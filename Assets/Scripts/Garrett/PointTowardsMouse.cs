using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointTowardsMouse : MonoBehaviour
{
    public Transform targetObject;

    void Update()
    {
        PointToTarget();
    }

    void PointToTarget()
    {
        if (targetObject != null)
        {
            // Calculate the direction from the object to the target object
            Vector3 lookDir = targetObject.position - transform.position;

            // Calculate the rotation angle based on the direction
            float angleZ = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;

            // Set the object's Z rotation to face the target object
            transform.rotation = Quaternion.Euler(0f, 0f, angleZ);
        }
        else
        {
            Debug.LogWarning("Target object is not assigned.");
        }
    }
}



