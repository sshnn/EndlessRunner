using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SectionDestructor : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        destroySection();
    }
    void destroySection()
    {
       if(GenerateLevel.tempObjs.Count > 3) 
       {
        Destroy(GenerateLevel.tempObjs[GenerateLevel.tempObjs.Count -4]);
       }
    }
}
