﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupBallSpeed : MonoBehaviour
{


    public  Ball ball;



    private void Start()
    {
        ball = FindObjectOfType<Ball>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Pad"))
        {
            
            
        }
    }
}
