using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePlayer : MonoBehaviour
{
    HealthBar health;

    public void Start()
    {
        health = GetComponent<HealthBar>();
    }
    void OnTriggerEnter(Collider other)
    {
        //  Debug.Log("collision");
        if(other.CompareTag("Enemy"))
        {
            //Debug.Log("wolf collision");

            health.takeDamage(5);
        }
    }
}
