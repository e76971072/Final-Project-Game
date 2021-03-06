﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    
    //Variables
    public int health = 10;
    public int level = 1;
    public bool gameRunning;

    public int enemyMaxPerRoom = 3;
    public int enemyCnt = 0;

    public void TakeDamage(int D) {
        health -= D;
        if(health <= 0) {
            GameOver();
        }
        health = Mathf.Max(health, 0);
    }

    public void RestoreHealth(int D) {
        health += D;
        health = Mathf.Min(health, 10);
    }

    void Start()
    {
        gameRunning = true;
         if(PlayerPrefs.HasKey("PlayerHealth"))
        {
            health = PlayerPrefs.GetInt("PlayerHealth");
        }
        else
        {
            PlayerPrefs.SetInt("PlayerHealth", health);
        }
        if(PlayerPrefs.HasKey("CurrentLevel"))
        {
            level = PlayerPrefs.GetInt("CurrentLevel");
        }
        else
        {
            PlayerPrefs.SetInt("CurrentLevel", level);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0 && gameRunning)
        {
            gameRunning = false;
            PlayerPrefs.DeleteKey("PlayerHealth");
            PlayerPrefs.DeleteKey("CurrentLevel");
            GameOver();
        }
    }
    public void ChangeLevel()
    {
        PlayerPrefs.SetInt("PlayerHealth", health);
        PlayerPrefs.SetInt("CurrentLevel", level + 1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void GameOver()
    {
        Debug.Log("GameOver!!");


        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex  + 1);

    }

    private void OnApplicationQuit()
    {
        PlayerPrefs.DeleteKey("PlayerHealth");
        PlayerPrefs.DeleteKey("CurrentLevel");
    }
}
