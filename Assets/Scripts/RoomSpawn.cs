using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomSpawn : MonoBehaviour
{
    //Used https://www.youtube.com/watch?v=eR74EjkA_4s Blackthornprod as reference for generation

    /*
    Clockwise starting with top
    1: Must open bottom
    2: Must open left
    3: Must open top
    4: Must open right
    */
    public int openDir;
    /*  maxRooms
        0: No Limit
        5: Minimum max room
    */
    public static int maxRooms = 20;
    public static int totalRooms = 1;
    private int rand;
    private RoomTemplates templates;
    private bool spawned = false;

    public float waitTime = 5f;

    void Start(){
        Destroy(gameObject, waitTime);
        templates = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplates>();
        Invoke("Spawn", .1f);
    }

    void Spawn(){
        if(spawned == false)
        {
            totalRooms++;
            //Bottom
            if(openDir == 1){
                if(maxRooms == 0 || totalRooms < maxRooms - 4)
                {
                    rand = Random.Range(0, templates.bottomRooms.Length);
                }
                else
                {
                    rand = 0;
                }
                Instantiate(templates.bottomRooms[rand], transform.position, templates.bottomRooms[rand].transform.rotation);
                
            //Left
            }else if(openDir == 2){
                if(maxRooms == 0 || totalRooms < maxRooms - 4)
                {
                    rand = Random.Range(0, templates.leftRooms.Length);
                }
                else
                {
                    rand = 0;
                }
                Instantiate(templates.leftRooms[rand], transform.position, templates.leftRooms[rand].transform.rotation);
                
            //Top
            }else if(openDir == 3){
                if(maxRooms == 0 || totalRooms < maxRooms - 4)
                {
                    rand = Random.Range(0, templates.topRooms.Length);
                }
                else
                {
                    rand = 0;
                }
                Instantiate(templates.topRooms[rand], transform.position, templates.topRooms[rand].transform.rotation);
                
            //Right
            }else if(openDir == 4){
                if(maxRooms == 0 || totalRooms < maxRooms - 4)
                {
                    rand = Random.Range(0, templates.rightRooms.Length);
                }
                else
                {
                    rand = 0;
                }
                Instantiate(templates.rightRooms[rand], transform.position, templates.rightRooms[rand].transform.rotation);
                
            }
            spawned = true;
        }
    }
    void OnTriggerEnter2D(Collider2D other){
        templates = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplates>();
        if(other.CompareTag("RoomSpawner"))
        {
            if(other.GetComponent<RoomSpawn>().spawned == false && spawned == false){
                //Wall
                Instantiate(templates.closedRoom, transform.position, Quaternion.identity);
                Destroy(gameObject);
            }
            spawned = true;
        }

    }
}
