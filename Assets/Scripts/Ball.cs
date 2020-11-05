﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Ball : MonoBehaviour
{
    public float speed;

    public Rigidbody2D rb;
    public Pad pad;


    int live = 3;
    bool isStarted;
    float yPosition;

    void Start()
    {
        yPosition = transform.position.y;
    }

    private void Update()
    {
        if (isStarted)
        {
            //мяч запущен
            //ничего не делаем
        }
        else
        {

            BallRestart();
            if (Input.GetMouseButtonDown(0)) //левая клавиша мыши
            {
                StartBall();
            }
        }

        //print(rb.velocity);
    }

    private void StartBall()
    {
        float randomX = UnityEngine.Random.Range(-5f, 5f);
        Vector2 direction = new Vector2(randomX, 1);
        Vector2 force = direction.normalized * speed;
        rb.AddForce(force);
        isStarted = true;
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawRay(transform.position, rb.velocity);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        live--;
        if (live <= 0)
        {
            print("Load Scene");
            SceneManager.LoadScene(0);
        }
        else
        {
            BallRestart();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        //print("Trigger exit");
    }
    void BallRestart()
    {
        Vector3 padPosition = pad.transform.position; //позиция платформы

        Vector3 ballNewPosition = new Vector3(padPosition.x, yPosition, 0); //новая позиция мяча
        transform.position = ballNewPosition;

        //проверить левую кнопку мыши
        isStarted = false;
    }

}

    