using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    
    public  Image cooldown;
    public static bool coolingDown;
    public static float waitTime = 30.0f;
    

    public float maxHealth = 10;
    private float originalScale;
    public GameController manager;

    void Awake()
    {
        manager = GameObject.Find("GameController").GetComponent<GameController>();
    }
    void Start()
    {
        originalScale = gameObject.transform.localScale.x;
    }
    // Update is called once per frame
    public void Update()
    {
        Vector3 tmp = gameObject.transform.localScale;
        tmp.x = manager.health / maxHealth * originalScale;
        gameObject.transform.localScale = tmp;

        
        if (coolingDown == true)
        {
            //Reduce fill amount over 30 seconds
            cooldown.fillAmount = 1; 

        }
    }
}
