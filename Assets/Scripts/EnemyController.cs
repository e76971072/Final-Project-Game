using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] GameObject target;
    [SerializeField] GameObject bullet;
    [SerializeField] int health;
    [SerializeField] int damage;
    [SerializeField] float shootSpeed;
    [SerializeField] float speed;
    [SerializeField] int enemyType;
    float timer = 0f;

    //Status of room, active enemy/dormant
    public bool status;

    // Start is called before the first frame update
    void Start()
    {
        if(!target)
        {
            target = GameObject.FindGameObjectWithTag("Player");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(health < 0)
        {
            Destroy(gameObject);
        }
        //If enemy is active
        if(status)
        {
            //Different types of enemies actions
            switch (enemyType)
            {
                case 1: //Shooter
                    {
                        Shooter();
                        break;
                    }
                case 2: //Chaser
                    {
                        Chaser();
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }
    }
   //Types
   void Chaser()
    {
        MoveToPlayer();
    }

    void Shooter()
    {
        //Aim at player
        transform.LookAt(target.transform.position);
        //Could need tweaking
        transform.Rotate(new Vector3(0, -90, 0), Space.Self);

        timer += Time.deltaTime;
        if (timer > shootSpeed)
        {
            timer = 0;
            //Spawn bullet
            Instantiate(bullet, transform.position, transform.rotation);
        }
    }
    //Actions
    void MoveToPlayer()
    {
        //transform.LookAt(target.transform.position);
        //transform.Rotate(new Vector3(0, -90, 0), Space.Self);
        if (Vector2.Distance(transform.position, target.transform.position) > 1f)
        {

            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);

        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        //Hit player
        if(col.gameObject.tag == "Player")
        {
            //Damage player
        }
        //Bullet hit
        else if(col.gameObject.tag == "Bullet")
        {
            //Take damage
            health--;
        }
    }
}
