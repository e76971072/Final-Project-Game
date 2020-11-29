using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    // Start is called before the first frame update
    public  Image healthImage;
    public static float healthCount = 1 ; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        healthImage.fillAmount = healthCount; 
        
    }
}
