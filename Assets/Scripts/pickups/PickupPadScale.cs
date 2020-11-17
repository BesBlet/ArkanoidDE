using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupPadScale : MonoBehaviour
{

    Pad pad;
    public Vector2 padScale;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.CompareTag("Pad"))
        {
            pad = FindObjectOfType<Pad>();
            pad.transform.localScale = padScale;
            Destroy(gameObject);
        }
    }
}
