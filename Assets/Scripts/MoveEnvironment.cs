using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnvironment : MonoBehaviour
{

    private GameObject[] environment = GameObject.FindGameObjectsWithTag("Environment");
    private Vector3 direction = Vector3.forward;
    private Vector3 currentPos;
    public GameObject obj;

    public void Update()
    {

            currentPos = obj.transform.position;
            currentPos.z += 1;
            obj.transform.position = currentPos;
    }
}
