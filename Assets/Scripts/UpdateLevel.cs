using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateLevel : MonoBehaviour
{
    [SerializeField] private GameController GameController;
    public Text Level_UIText;
    private int currentLevel;
    // Start is called before the first frame update
    void Start()
    {
        if(!GameController)
        {
            GameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        }
        currentLevel = GameController.level;
    }

    // Update is called once per frame
    void Update()
    {
        Level_UIText.text =  "Level: " + GameController.level.ToString();
    }
}
