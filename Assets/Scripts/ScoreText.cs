using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreText : MonoBehaviour
{
    public void SetScoreText(int score)
    {
        GetComponent<TMP_Text>().text = "Score: " + Mathf.Round(score);
    }
}

