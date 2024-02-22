using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    void Update()
    {
        PointObject();
    }

    void PointObject()
    {
        // Get the mouse position in the world space
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane));

        // Calculate the angle in radians
        float angleRad = Mathf.Atan2(mousePos.y - transform.position.y, mousePos.x - transform.position.x);

        // Convert the angle to degrees and set only the Z-axis rotation
        float angleDeg = angleRad * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, angleDeg);
    }
}










