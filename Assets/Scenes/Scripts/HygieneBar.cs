using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HygieneBar : MonoBehaviour
{
    public Slider slider;
    //public Gradient gradient;
    //public Image fill;



    public void SetMaxHygiene(float hygiene)
    {
        slider.maxValue = hygiene;
        slider.value = hygiene;

    }

    public void SetHygiene(float hygiene)
    {
        slider.value = hygiene;
    }

    public void Take_Damage_H(float damageTaken)
    {
        slider.value -= damageTaken;


    }

    /// <summary>
    /// Get Current Hygiene
    /// The value of the slider
    /// </summary>
    /// <param name=""></param>
    /// <returns><strong>Returns the value of the slider as a float</strong></returns>
    public float GetCurrentHygiene()
    {

        Debug.Log("hygiene: " + slider.value);
        return slider.value;

    }



    // void Update { 
    // health = currentHealth;
    //  }

}