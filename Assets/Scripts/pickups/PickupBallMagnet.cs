using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupBallMagnet : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Pad"))
        {

            Destroy(gameObject);
        }
    }
}
