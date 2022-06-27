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
       if(GenerateLevel.sectionObjs.Count > 8) 
       {
        Destroy(GenerateLevel.sectionObjs[GenerateLevel.sectionObjs.Count -9]);
        GenerateLevel.sectionObjs.RemoveAt(GenerateLevel.sectionObjs.Count -9);
       }

       if(GenerateLevel.gameOver) 
        {
            for (int i = 0; i < GenerateLevel.sectionObjs.Count; i++)
                GenerateLevel.sectionObjs.RemoveAt(i);
            GenerateLevel.gameOver = false;
        }

    }
}
