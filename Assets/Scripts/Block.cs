using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Block : MonoBehaviour

{

    public int punch;

    public void OnCollisionEnter2D(Collision2D collision)
    {

        print("Block Collision");
        if (punch <= 0)
        {
            Destroy(gameObject);
        }
        else
        {
            print("Punch");
            punch--;
        }
    }
}
