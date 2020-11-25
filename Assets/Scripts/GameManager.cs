﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text scoreText;
    public Text lifeText;
    public GameObject panelPause;

    [HideInInspector]
    public bool pauseActive;
    public int lifes;
    
    
    int score;
 

    private void Awake()
    {
        GameManager[] gameManagers = FindObjectsOfType<GameManager>();
        for (int i = 0; i < gameManagers.Length; i++)
        {
            if (gameManagers[i].gameObject != gameObject)
            {
                Destroy(gameObject);
                gameObject.SetActive(false);
                break;
            }

        }
    }

    private void Start()
    {
        lifes = 3;
        lifeText.text = lifes.ToString();
        scoreText.text = "000";

        DontDestroyOnLoad(gameObject);
    }

    public void AddScore(int addScore)
    {
        score += addScore;
        scoreText.text = score.ToString();
    }

    public void AddLifes(int addLifes)
    {
        lifes += addLifes;
        lifeText.text = lifes.ToString();
        
    }
    public void LoseLife()
    {
        lifes--;
        lifeText.text = lifes.ToString();

        if (lifes <= 0)
        {
            Start();
            SceneManager.LoadScene(0);// to do сделать загрузку по индексу
            Destroy(gameObject);
        }
        


    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (pauseActive)
            {
                //пауза уже активна - вернуть время в 1
                Time.timeScale = 1f;
                pauseActive = false;
            }
            else
            {
                //включить паузу
                Time.timeScale = 0f;
                pauseActive = true;
            }
            panelPause.SetActive(pauseActive);
        }
    }
}
