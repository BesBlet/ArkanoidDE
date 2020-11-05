using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Block : MonoBehaviour

{
    public Sprite[] sprites;
    private SpriteRenderer cursprite;
    public int punch;

    private void Start()
    {
        cursprite = GetComponent<SpriteRenderer>();
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {

        print("Punch");
        punch--;
        int i = 0;
        if (punch <= 0)
            {
                Destroy(gameObject);
            }
        else
        {
            cursprite.sprite = sprites[i];
            i++;                                              
        }
        
        
       
    }
}
