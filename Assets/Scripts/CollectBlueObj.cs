using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectBlueObj : MonoBehaviour
{


    private void OnTriggerEnter(Collider other) 
    {
        GenerateLevel.scoreCount++;
        gameObject.SetActive(false);
    }

    
    
}

