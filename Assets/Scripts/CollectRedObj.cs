using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectRedObj : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) 
    {
        GenerateLevel.scoreCount--;
        gameObject.SetActive(false);
    }
}
