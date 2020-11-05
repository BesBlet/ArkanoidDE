using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pad : MonoBehaviour
{
    public bool autoplay;
    public float maxX;
    float yPosition;

    Ball ball;

    // Start is called before the first frame update
    void Start()
    {
        ball = FindObjectOfType<Ball>();
        yPosition = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (autoplay)
        {
           
        }
        else
        {
            Vector3 mousePixelPosition = Input.mousePosition; //позиция мыши в координатах экрана
            Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint(mousePixelPosition); //позиция мыши в координатах игрового мира


            Vector3 padNewPosition = new Vector3(mouseWorldPosition.x, yPosition, 0);

            padNewPosition.x = Mathf.Clamp(padNewPosition.x, -maxX, maxX);

            transform.position = padNewPosition;
        }
        
    }
}