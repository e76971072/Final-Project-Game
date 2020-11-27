using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearDoorways : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Wall")
        {
            DestroyObject(gameObject);
        }
        else if( col.gameObject.tag == "ClosedRoom")
        {
            DestroyObject(col.gameObject);
            DestroyObject(gameObject);
        }
    }
}
