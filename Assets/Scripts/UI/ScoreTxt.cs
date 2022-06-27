using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreTxt : MonoBehaviour
{

    public static TextMeshProUGUI scoreTxt;

    // Start is called before the first frame update
    void Start()
    {
        scoreTxt = GetComponent<TextMeshProUGUI>();
        
    }

    // Update is called once per frame
    void Update()
    {
        getScore();
        printTotalScore();
    }

    static void getScore()
    {
        scoreTxt.text = "SCORE " + (Player.greenScore - Player.redScore) +"\n" +
        "GREEN " + Player.greenScore + "\n" + "RED     " + Player.redScore;
        scoreTxt.alignment = TextAlignmentOptions.Left;
        scoreTxt.color = Color.blue;
    }
    static public IEnumerator  printTotalScore()
    {
        if(GenerateLevel.gameOver) {
            scoreTxt.fontSize = 60;
            scoreTxt.color = Color.black;
            getScore();
            yield return new WaitForSeconds(2);
            SceneManager.LoadScene(0);

        }
    }
}
