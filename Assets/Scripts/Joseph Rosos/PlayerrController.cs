using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerrController : MonoBehaviour
{
    private float nextTimeOfFire = 0;
    public float movespeed = 5f;
    public Rigidbody2D rb;
    public Weapon currentWeapon;
    public GameObject bulllet;

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

        if (Input.GetMouseButtonDown(0))
        {
            if(Time.time >= nextTimeOfFire)
            {
                currentWeapon.Fire();
                //nextTimeOfFire = Time.time + 1 / currenteapon.fireRate;
            }
            
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

}
