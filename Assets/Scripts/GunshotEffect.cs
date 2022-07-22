using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GunshotEffect: MonoBehaviour
{

    //Shooting Gun Effect
    public MusicManager musicManager;
    public GameObject partical;

    public void shootEffect()
    {
        partical.SetActive(false);
        partical.SetActive(true);
        musicManager.Play("GunShot");
    }

    //Raycast Collision Check

}
