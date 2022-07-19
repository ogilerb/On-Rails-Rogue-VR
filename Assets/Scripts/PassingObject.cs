using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassingObject : MonoBehaviour
{
    public float movingForce;
    public Transform environment;
    public GameObject wall;

    private void Start()
    {
        environment.transform.Translate(Vector3.back);

    }


}
