using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Block : MonoBehaviour

{
    public int points;
    public Sprite[] sprites;
    public bool invulnerable;

    private SpriteRenderer cursprite;
    public int punch;
    private int cpunch;
    
    LevelManager levelManager;
    GameManager gameManager;
    

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        levelManager = FindObjectOfType<LevelManager>();
        levelManager.BlockCreated();
        cursprite = GetComponent<SpriteRenderer>();
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {

        if (invulnerable)
        {
            print("Invulnerable");
        }
        else
        {
            print("Punch");

            punch--;
        
            cpunch++;
        
            if (cpunch <= sprites.Length)
            {
                cursprite.sprite = sprites[cpunch - 1];  
            }
        
            if (punch <= 0)
            
            {
                levelManager.BlockDestroyed();
                Destroy(gameObject);
                gameManager.AddScore(points * cpunch);
            }

        }

    }
}
