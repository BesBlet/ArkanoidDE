using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseGame : MonoBehaviour
{
    GameManager gameManager;
    Ball ball;
    public bool twoBalls;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        ball = FindObjectOfType<Ball>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if (collision.gameObject.tag == "Ball")
        if (collision.gameObject.CompareTag("Ball"))
        {
            if (twoBalls)
            {
                twoBalls = false;
            }
            else
            {
                //если мяч - отнять жизнь
                gameManager.LoseLife();
                ball.Restart();
            }
           
        }
        else
        { 
            //если не мяч - унчитожить объект
            Destroy(collision.gameObject);
        }
    }
}