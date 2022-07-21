using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class XRRayCastVisual : MonoBehaviour
{
    private void Start()
    {
        gameObject.GetComponent<XRInteractorLineVisual>();
    }

    void Update()
    {
        
    }
}
