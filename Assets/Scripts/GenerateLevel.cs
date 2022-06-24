using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GenerateLevel : MonoBehaviour
{

    public GameObject[] section;
    public int zPos = -55;
    public bool creatingSection = false;
    public int secNum;
    public static int scoreCount = 0;
   
    void Update()
    {
        if(creatingSection == false)
        {
            creatingSection = true;
            StartCoroutine(generateSection());
        }
    }

    IEnumerator generateSection()
    {
        secNum = Random.Range(0, 3);
        Instantiate(section[secNum], new Vector3(-0.7f, 3f, zPos), Quaternion.identity);
        zPos -= 50;
        yield return new WaitForSeconds(5);
        creatingSection = false;
    }

    private void OnTriggerEnter(Collider other) 
    {
        Debug.Log("engel!!");
    }
}
