using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public  Image cooldown;
    public static bool coolingDown;
    public static float waitTime = 30.0f;

    // Update is called once per frame
    public void Update()
    {
        if (coolingDown == true)
        {
            //Reduce fill amount over 30 seconds
            cooldown.fillAmount = 1; 

        }
    }
}
