using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class XRRayCastVisual : MonoBehaviour
{
    void Update()
    {
        if (selected)
        {
            gameObject.GetComponent<XRInteractorLineVisual>().enabled =false;
        }
        else
        {
            gameObject.GetComponent<XRInteractorLineVisual>().enabled =true;
        }
    }

    private bool selected;

    public void UnSelect()
    {

        selected = false;

    }

    public void Selec()
    {

        selected = true;

    }
}
