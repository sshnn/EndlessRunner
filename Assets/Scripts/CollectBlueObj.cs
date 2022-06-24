using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectBlueObj : MonoBehaviour
{


    private void OnTriggerEnter(Collider collision) 
    {
        if(collision.tag == "blueObj") {
            GenerateLevel.scoreCount++;
            gameObject.SetActive(false);
        }

        if(collision.gameObject.CompareTag ("redObj")) {
            GenerateLevel.scoreCount--;
            gameObject.SetActive(false);
        }
        
    }

    
    
}

