using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomController : MonoBehaviour
{
    //List of enemies
    public GameObject[] enemies;
    public GameObject[] doors;
    public bool active = false;
    public bool newRoom = true;

    public GameController manager;

    public int customEnemySpawn = -1;

    // Start is called before the first frame update
    void Awake(){
        manager = GameObject.Find("GameController").GetComponent<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(active && newRoom)
        {
            newRoom = false;

            int spawnNum = manager.enemyMaxPerRoom;
            if(customEnemySpawn > -1)
                spawnNum = customEnemySpawn;


            for (int i = 0; i < spawnNum; i++)
            {
                manager.enemyCnt++;
                SpawnEnemies();
            }
        }

        if(active){
            for (int i = 0; i < doors.Length; i++)
            {
                doors[i].SetActive(true);
            }
        }

        if(active && manager.enemyCnt <= 0){
            active = false;
            for (int i = 0; i < doors.Length; i++)
            {
                doors[i].SetActive(false);
            }
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
            if(newRoom)
                active = true;
        }
    }

}
