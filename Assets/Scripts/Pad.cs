using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pad : MonoBehaviour
{
    float yPosition;

    // Start is called before the first frame update
    void Start()
    {
        yPosition = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePixelPosition = Input.mousePosition;
        Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint(mousePixelPosition);

        Vector3 padNewPosition = mouseWorldPosition;


        padNewPosition.z = 0;

        padNewPosition.y = yPosition;



        transform.position = padNewPosition;
    }
}
