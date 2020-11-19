using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupBallSpeed : MonoBehaviour
{

    

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.CompareTag("Pad"))
        {
            Ball ball = FindObjectOfType<Ball>();    
            
        }
    }
}
