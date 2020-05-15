using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;
    //public Gradient gradient;
	//public Image fill;



    public void SetMaxHealth(float health)
    {
        slider.maxValue = health;
        slider.value = health;
        
    }

    public void SetHealth(float health)
    {
        slider.value = health;
    }

    public void Take_Damage(float damageTaken)
    {
        slider.value -= damageTaken;


    }
    




    /// <summary>
    /// Get Current Health
    /// The value of the slider
    /// </summary>
    /// <param name=""></param>
    /// <returns><strong>Returns the value of the slider as a float</strong></returns>
    public float GetCurrentHealth()
    {
        
        Debug.Log("health: " + slider.value);
        return slider.value;
        
    }



   // void Update { 
       // health = currentHealth;
  //  }

}
