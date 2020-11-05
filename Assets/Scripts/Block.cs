using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Block : MonoBehaviour

{
    public int points;
    LevelManager levelManager;
    GameManager gameManager;
    public Sprite[] sprites;
    private SpriteRenderer cursprite;
    public int punch;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        levelManager = FindObjectOfType<LevelManager>();
        levelManager.BlockCreated();
        cursprite = GetComponent<SpriteRenderer>();
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        gameManager.AddScore(points);

        print("Punch");

        punch--;

        int i = 0;
        if (punch <= 0)
            {
                levelManager.BlockDestroyed();
                Destroy(gameObject);
            }
        else
        {
            cursprite.sprite = sprites[i];
            i++;                                              
        }
        
        
       
    }
}
