using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupLife : MonoBehaviour
{
    public int addLifes;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Pad"))
        {
            GameManager gameManager = FindObjectOfType<GameManager>();
            gameManager.lifes += addLifes;
            Destroy(gameObject);
        }
    }
}
