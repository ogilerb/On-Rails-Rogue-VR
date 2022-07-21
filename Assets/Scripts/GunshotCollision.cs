using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunshotCollision: MonoBehaviour
{
    GunshotTrail trail;
    public float range = 20;
    
    
    public void Start()
    {
        trail = GetComponent<GunshotTrail>();
    }

    public void gunshotCollision()
    {

        Vector3 direction = Vector3.forward;
        Ray gunShotTrail = new Ray(transform.position, transform.TransformDirection(direction * range));

        if (Physics.Raycast(gunShotTrail, out RaycastHit hit, range))
        {

            trail.checkTrail(hit.distance);

            if (hit.collider.tag == "Enemy")
            {

                Destroy(hit.collider.gameObject);


            }

        }

    }
}
