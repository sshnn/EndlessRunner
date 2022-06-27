using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle012 : MonoBehaviour
{
    public int rotateSpeed = 1;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, rotateSpeed, Space.World);
        
    }
}
