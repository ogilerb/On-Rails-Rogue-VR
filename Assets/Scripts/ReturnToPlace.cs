using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnToPlace : MonoBehaviour
{

    public Transform ReturnPoint;

    public void TurnToPlace()
    {

        transform.position = ReturnPoint.position;
        transform.rotation = ReturnPoint.rotation;


    }

}
