using UnityEngine;
using System.Collections;
using UnityEngine.UI; // Required when Using UI elements.

public class Cooldown : MonoBehaviour
{
    public static Image cooldown;
    public static bool coolingDown;
    public static float waitTime = 30.0f;

    // Update is called once per frame
    public void Update ()
    {
        if (coolingDown == true)
        {
            //Reduce fill amount over 30 seconds
            cooldown.fillAmount =  0.9f;
            
        }
    }
}