using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public TMP_Text scoretext;
    public TMP_Text FinalScoreText;
    int myScore = 0;


    public void AddScore()
    {
        myScore++;
        scoretext.text = myScore.ToString();
    }
    public void ShowFinalScore()
    {
        FinalScoreText.text = myScore.ToString();
    }
}
