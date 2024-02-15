using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieAI : MonoBehaviour
{
    public GameObject New_Piskel;
    public float speed;
    public float distanceBetween;

    public float distance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector2.Distance(transform.position, New_Piskel.transform.position);
        Vector2 direction = New_Piskel.transform.position - transform.position;
        direction.Normalize();
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        if(distance < distanceBetween)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, New_Piskel.transform.position, speed * Time.deltaTime);
            transform.rotation = Quaternion.Euler(Vector3.forward * angle);
        }
    }
}
