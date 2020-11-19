using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupTwoBall : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.CompareTag("Pad"))
        {
            LoseGame loseGame = FindObjectOfType<LoseGame>();
            if (loseGame.twoBalls)
            {
               return; 
            }
            else
            {
                Ball ball = FindObjectOfType<Ball>();
                ball.TwoBalls();
            }
            
            
        }
    }
}
