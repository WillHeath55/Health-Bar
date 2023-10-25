using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthBar : MonoBehaviour
{


    public Slider slider;
    public Gradient gradient;
    public Gradient gradient2;
    public Image fill;
    public Image heart;


    public void SetMaxhealth(int health)
    { 
        slider.maxValue = health;
        slider.value = health;


        fill.color = gradient.Evaluate(1f);
        heart.color = gradient2.Evaluate(1f);
    }
    
    public void SetHealth(int health)
    {
        slider.value = health; 

        fill.color = gradient.Evaluate(slider.normalizedValue);
        heart.color = gradient2.Evaluate(slider.normalizedValue);
    }

    
 
}
