using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpScore : MonoBehaviour
{
    public int points;

    private void ApplyEffect()
    {
        GameManager gameManager = FindObjectOfType<GameManager>();
        gameManager.AddScore(points);
        print("Apply Effect");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Pad"))
        {
            ApplyEffect();
            Destroy(gameObject);
        }
    }
}
