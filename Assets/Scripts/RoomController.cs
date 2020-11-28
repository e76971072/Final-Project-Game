using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomController : MonoBehaviour
{
    //List of enemies
    public GameObject[] enemies;
    public bool active = false;
    public bool newRoom = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(active && newRoom)
        {
            newRoom = false;
            //For loop of how many enemies
            SpawnEnemies();
        }
    }
    private void SpawnEnemies()
    {
        float xPos = Random.Range((transform.position.x - 4), (transform.position.x + 4));
        float yPos = Random.Range((transform.position.y - 4), (transform.position.y + 4));
        int type = Random.Range(0, enemies.Length);

        Instantiate(enemies[type], new Vector3(xPos, yPos, -1), Quaternion.identity);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            active = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            active = false;
        }
    }
}
