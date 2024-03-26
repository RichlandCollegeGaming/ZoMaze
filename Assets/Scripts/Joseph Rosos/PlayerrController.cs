using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float nextTimeOfFire = 0;
    private bool isFiring = false; // Flag to track if the weapon is currently firing
    public float movespeed = 5f;
    public Rigidbody2D rb;
    public Weapon currentWeapon;
    public GameObject bullet;

    Vector2 moveDirection;
    Vector2 mousePosition;

    private void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        if (Input.GetKey(KeyCode.LeftShift))
            movespeed = 10f;
        else
            movespeed = 5f;

        // Check if the player pressed the fire button and if the weapon is ready to fire
        if (Input.GetMouseButtonDown(0) && !isFiring && Time.time >= nextTimeOfFire)
        {
            // Set the weapon as firing
            isFiring = true;
            // Fire the weapon
            currentWeapon.Fire();
            // Set the next allowed fire time based on the weapon's fire rate and delay
           // nextTimeOfFire = Time.time + 1f / currentWeapon.fireRate;
            // Reset the firing flag after a delay
          //  StartCoroutine("ResetFiring", (currentWeapon.shootDelay));
        }

       

        moveDirection = new Vector2(moveX, moveY).normalized;
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(moveDirection.x * movespeed, moveDirection.y * movespeed);

        Vector2 aimDirection = mousePosition - rb.position;
        float aimAngle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = aimAngle;
    }

    // Method to reset the firing flag
    private void ResetFiring()
    {
        isFiring = false;
    }
}
