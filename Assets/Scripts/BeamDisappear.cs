using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class BeamDisappear : MonoBehaviour
{

    public void disappear()
    {
        this.GetComponent<XRInteractorLineVisual>().enabled = false;
    }

    public void reappear()
    {
        this.GetComponent<XRInteractorLineVisual>().enabled = true;
    }

}
