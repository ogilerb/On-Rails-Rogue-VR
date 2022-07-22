using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GunshotEffect: MonoBehaviour
{

    //Shooting Gun Effect
    public GameObject partical;

    public void shootEffect()
    {
        partical.SetActive(false);
        partical.SetActive(true);
        FindObjectOfType<MusicManager>().Play("GunShot");
    }

    //Raycast Collision Check

}
