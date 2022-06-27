using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GenerateLevel : MonoBehaviour
{

    public GameObject[] section;
    public int zPos = -55;
    public bool creatingSection = false;
    public int sectionIdx;
    public static List<GameObject> sectionObjs = new List<GameObject>();
    public static bool gameOver = false;
    
    

    void Update()
    {
        
        if(!creatingSection)
        {
            creatingSection = true;
            StartCoroutine(generateSection());
        }
    }


    void addSection(int randomIdx) 
    {
        sectionObjs.Add(Instantiate(section[randomIdx], new Vector3(-0.7f, 3f, zPos), Quaternion.identity));
    }

    int getSectionSize()
    {
        return sectionObjs.Count;
    }

    IEnumerator generateSection()
    {
        int sec = 0;
        if(getSectionSize() > 3)
            sec = 5;
        addSection(Random.Range(0, 4));
        zPos -= 50;
        yield return new WaitForSeconds(sec);
        creatingSection = false;
    }

}
