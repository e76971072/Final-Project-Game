using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthbar : MonoBehaviour
{
    public Image cooldown;
    public static bool coolingDown;
    public static float waitTime = 30.0f;
    internal static float healthCount = 1;

    public float maxHealth = 30;
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

        //cooldown.fillAmount = healthCount;


    }
}
