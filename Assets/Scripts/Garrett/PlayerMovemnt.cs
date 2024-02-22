using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovemnt : MonoBehaviour
{
    public float moveSpeed = 5f;

    public Rigidbody2D rb;
    public Camera cam;

    Vector2 movement;
    Vector2 mousePos;


    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        //HandleRotationInput();

        //mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }

    

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);


        /*
       
        Vector2 lookDir = mousePos - rb.position;
       float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
       rb.rotation = angle;


     */
    }

    /*
    
    void HandleRotationInput()
    {
        RaycastHit _hit;
        Ray _ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(_ray, out _hit))
        {
            // Look at the hit point
            transform.LookAt(new Vector3(_hit.point.x, transform.position.y, _hit.point.z));

            // Draw a debug ray to visualize the hit point
            Debug.DrawRay(_ray.origin, _ray.direction * _hit.distance, Color.red);
        }
        else
        {
            // If no hit, use the ray direction to determine where to look
            transform.LookAt(_ray.origin + _ray.direction * 10f);

            // Draw a debug ray to visualize the direction when not hitting anything
            Debug.DrawRay(_ray.origin, _ray.direction * 10f, Color.green);
        }
    }

   */

}
