using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWithPlayer : MonoBehaviour
{

    private GameObject[] environment;
    private Vector3 direction = Vector3.forward;
    private Vector3 currentPos;

    public void Update()
    {

        environment = GameObject.FindGameObjectsWithTag("MoveWithPlayer");

        foreach (GameObject obj in environment)
        {
            currentPos = obj.transform.position;
            currentPos.z += 0.03f;
            obj.transform.position = currentPos;
        }

    }

}