using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Image cooldown;
    public static bool coolingDown;
    public static float waitTime = 30.0f;
    internal static float healthCount = 1;

    // Update is called once per frame
    public void Update()
    {

        cooldown.fillAmount = healthCount;


    }
}
