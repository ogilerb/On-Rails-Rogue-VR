using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthBar : MonoBehaviour
{
    public Slider slider;
    private Scene scene;

    public void Start()
    {
        scene = SceneManager.GetActiveScene();
    }
    public void takeDamage(int health)
    {
        slider.value -= health;
        //Debug.Log(slider.value.ToString());
    }

    /*
    public void setHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
        cHealth = health;
    }
    */

    public void Update()
    {
        if(slider.value.Equals(0))
        {
            SceneManager.LoadScene(scene.name);
        }
    }

}
