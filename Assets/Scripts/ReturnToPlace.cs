using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnToPlace : MonoBehaviour
{

    public Transform ReturnPoint;
    public Rigidbody rb;
    public bool selected;

    public void TurnToPlace()
    {

        selected = false;

    }

    public void FixedUpdate()
    {

        if (!selected)
        {
            transform.position = ReturnPoint.position;
            transform.rotation = ReturnPoint.rotation;

            rb.velocity.Set(0, 0, 0);
        }

    }

    public void Selec()
    {

        selected = true;

    }

}

