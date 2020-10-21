using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomTemplates : MonoBehaviour
{
    public GameObject[] topRooms;
    public GameObject[] rightRooms;
    public GameObject[] bottomRooms;
    public GameObject[] leftRooms;

    public GameObject closedRoom;

    public List<GameObject> rooms;

    public float bufferTime = 2f;
    private bool spawnEndRoom = true;
    public GameObject exit;

    void Update(){
        if(spawnEndRoom == true && bufferTime <= 0)
        {
            for (int i = 0; i < rooms.Count; i++) {
                if(i == rooms.Count-1){
                    Instantiate(exit, rooms[i]. transform.position, Quaternion.identity);
                    spawnEndRoom = false;
                }
            }
        }
        else {
            bufferTime -= Time.deltaTime;
        }
    }
}
