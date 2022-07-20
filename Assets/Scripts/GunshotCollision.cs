using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunshotCollision: MonoBehaviour
{
    public GameObject gunObject;
    public float range = 20;

    // Update is called once per frame

    public void Update()
    {
        //Vector3 direction = Vector3.forward;
        //Debug.DrawRay(transform.position, transform.TransformDirection(direction * range), Color.green);
    }

    public void gunshotCollision()
    {

        Vector3 direction = Vector3.forward;
        Ray gunShotTrail = new Ray(transform.position, transform.TransformDirection(direction * range));

        if (Physics.Raycast(gunShotTrail, out RaycastHit hit, range))
        {

            Debug.Log(hit.collider.name);
            
        }

    }
}
