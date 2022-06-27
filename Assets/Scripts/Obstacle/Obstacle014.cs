using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle014 : MonoBehaviour
{
    public int rotateSpeed = 3;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotateSpeed, 0, 0, Space.World);
        
    }
}
