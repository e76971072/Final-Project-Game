using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitController : MonoBehaviour
{
    [SerializeField] private GameController gameController;
    public bool check = false;
    // Start is called before the first frame update
    void Start()
    {
        if(!gameController)
        {
            gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        }
    }

    // Update is called once per frame
    void Update()
    {
    
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            gameController.GetComponent<GameController>().ChangeLevel();
        }
    }
}
