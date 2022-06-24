using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreTxt : MonoBehaviour
{

    public TextMeshProUGUI scoreTxt;

    // Start is called before the first frame update
    void Start()
    {
        scoreTxt = GetComponent<TextMeshProUGUI>();
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreTxt.text = "" + GenerateLevel.scoreCount;
        
    }
}
