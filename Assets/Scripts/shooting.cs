using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform firepoint;
    public GameObject bulletPrefabs;
    public float bulletForce = 40f; 

    // Update is called once per frame
    void Update()
    {

        if ( Input.GetKey ("space"))
        {
            Shooting(); 
        }
        
    }

    void Shooting()
    {
        GameObject bullet = Instantiate(bulletPrefabs, firepoint.position, firepoint.rotation);
        Rigidbody2D RB = bullet.GetComponent<Rigidbody2D>();
        RB.AddForce(firepoint.up * bulletForce, ForceMode2D.Impulse);
    }
}
