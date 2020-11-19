﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupBallMagnet : MonoBehaviour
{
    private Ball ball;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Pad"))
        {
            ball = FindObjectOfType<Ball>();
            ball.ballMagnet = true;
            Destroy(gameObject);
        }
    }
}
