using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Menu : MonoBehaviour
{
    bool isPaused = false;
    public GameObject menu;

    public void Paused(InputAction.CallbackContext context)
    {
        //Debug.Log("Paused!");

        if (context.performed)
        {
            if (isPaused)
            {
                Time.timeScale = 1;
                menu.SetActive(false);
                isPaused = false;
                //Debug.Log("Paused!");
            }
            else
            {
                Time.timeScale = 0;
                menu.SetActive(true);
                isPaused = true;
            }
        }
    }
    
}
