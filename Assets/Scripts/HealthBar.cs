using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;
    //private int cHealth = 25;

    public void setHealth(int health)
    {
        slider.value = health;
        //cHealth -= health;
    }

    public void setMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
        //cHealth = health;
    }

}
