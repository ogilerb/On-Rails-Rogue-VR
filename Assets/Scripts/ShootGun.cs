using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ShootGun : MonoBehaviour
{

    public GameObject partical;
    public GameObject gun;

    public void shootEffect(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            partical.SetActive(false);
            partical.SetActive(true);
        }


    }

}
