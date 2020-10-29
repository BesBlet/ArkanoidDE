using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    public Pad pad;
    bool isStarted;
    float yPosition;


    void Start()
    {
        yPosition = transform.position.y;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("Collision!");
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        print("Collision Exit!");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("Trigger!");
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        print("Trigger exit!");
    }



    void Update()
    {
        if(isStarted)
        {

        }

        else

        {
            Vector3 padPosition = pad.transform.position;
            Vector3 BallNewPosition = new Vector3(padPosition.x, padPosition.y + yPosition, 0);
            transform.position = BallNewPosition;


            if (Input.GetMouseButtonDown(0))
            {
                print("Start!");
                StartBall();
            }
        }

    }

   void StartBall()
    {
        isStarted = true;
        Vector2 force = new Vector2(10, 1) * speed;
        rb.AddForce(force);
    }
}

