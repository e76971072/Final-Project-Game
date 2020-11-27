using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    // Start is called before the first frame update
    public  Transform firepoint;
    public GameObject bulletPrefab;
    public float speed = 20f; 
    // Update is called once per frame
    void Update()
    {
        if ( Input.GetKeyDown("space"))
        {
            Shoot(); 
        }
        
    }
    void Shoot ()
    {

        Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
       
    }
}
