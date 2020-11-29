using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coins : MonoBehaviour
{


    [SerializeField] int coinReward = 100;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {

        if ( collision.tag == "Player")
        {
            // HealthBar.restoreHealth(0.2f); // TODO: We should have a good api to restore/damage
            GameObject.Find("GameController").GetComponent<GameController>().RestoreHealth(2);
            Destroy(gameObject);

        }
    }
}
