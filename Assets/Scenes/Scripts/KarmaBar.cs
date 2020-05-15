using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KarmaBar : MonoBehaviour
{
    public Slider slider;
    //public Gradient gradient;
    //public Image fill;



    public void SetMaxKarma(float karma)
    {
        slider.maxValue = karma;
        slider.value = 0;
        //sets karma meter to zero so it can be filled
    }

    public void SetKarma(float karma)
    {
        slider.value = karma;
    }

    public void FullKarma(float fullKarma_K)
    {
        slider.value += fullKarma_K;


    }

    /// <summary>
    /// Get Current Karma
    /// The value of the slider
    /// </summary>
    /// <param name=""></param>
    /// <returns><strong>Returns the value of the slider as a float</strong></returns>
    public float GetCurrentKarma()
    {

        Debug.Log("karma: " + slider.value);
        return slider.value;

    }



    // void Update { 
    // health = currentHealth;
    //  }

}