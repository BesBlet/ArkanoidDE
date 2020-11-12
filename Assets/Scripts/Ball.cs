using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Ball : MonoBehaviour
{
    public float speed;

    public Rigidbody2D rb;
    public Pad pad;
    public GameManager LgameManager;
   
    
  
    
    bool isStarted;
    float yPosition;

    void Start()
    {
        LgameManager = FindObjectOfType<GameManager>();
        pad = FindObjectOfType<Pad>();
        yPosition = transform.position.y;
        if (pad.autoplay)
        {
            StartBall();
        }
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
        rb.velocity = force;
        isStarted = true;
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawRay(transform.position, rb.velocity);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        LgameManager.live--;
       

        if (LgameManager.live <= 0)
        {
            LgameManager.gameOverText.gameObject.SetActive(true);
            LgameManager.backgroundImage.gameObject.SetActive(true);
            LgameManager.restartButton.gameObject.SetActive(true);
            Cursor.visible = true;
            print("Load Scene");
            LgameManager.live = 3;
           //
        }
        else
        {
            isStarted = false;
            BallRestart();
        }
    }
    
    void BallRestart()
    {
        LgameManager.LifeImage();
        LgameManager.LiveViewer();
        Vector3 padPosition = pad.transform.position; //позиция платформы

        Vector3 ballNewPosition = new Vector3(padPosition.x, yPosition, 0); //новая позиция мяча
        transform.position = ballNewPosition;

        //проверить левую кнопку мыши
    }

}

    