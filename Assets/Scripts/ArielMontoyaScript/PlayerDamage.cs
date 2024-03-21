using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    public int damageAmount = 10;
    Health healthScript;

    void Start()
    {
        healthScript = GetComponent<Health>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            healthScript.TakeDamage(damageAmount);
        }
    }
}
