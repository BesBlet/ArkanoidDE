using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    
    void Start()
    {

        //Invoke(nameof(TestDelay), 3f);

        StartCoroutine(TestDelay(3f));
    }


    IEnumerator TestDelay(float delay)
    {
        print("Delay start");
        yield return new WaitForSeconds(delay);
        print("Delay Finish");
        StartCoroutine(TestDelay(delay));
    }
   
}
