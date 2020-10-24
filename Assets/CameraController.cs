using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraController : MonoBehaviour
{
    public GameObject camObj;
    public CinemachineVirtualCamera vCam;
    private Transform target;

    void OnTriggerEnter2D (Collider2D collider)
    {
        if(collider.CompareTag("Player") && !collider.isTrigger){
            camObj.SetActive(true);
            target = collider.transform;
            vCam.Follow = target;
            vCam.m_Lens.OrthographicSize = 2.5f;
        }
    }

    void OnTriggerExit2D (Collider2D collider)
    {
        if(collider.CompareTag("Player") && !collider.isTrigger){
            camObj.SetActive(false);
        }
    }
}
