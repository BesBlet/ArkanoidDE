using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupBallScale : MonoBehaviour
{

    public GameObject ball;
    public Vector2 ballScale;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Pad"))
        {
            ball.transform.localScale = ballScale;
            Destroy(gameObject);
        }
    }
}
