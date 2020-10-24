using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject vCam;
    void OnTriggerEnter2D (Collider2D collider)
    {
        if(collider.CompareTag("Player") && !collider.isTrigger){
            vCam.SetActive(true);
        }
    }

    void OnTriggerExit2D (Collider2D collider)
    {
        if(collider.CompareTag("Player") && !collider.isTrigger){
            vCam.SetActive(false);
        }
    }
}
