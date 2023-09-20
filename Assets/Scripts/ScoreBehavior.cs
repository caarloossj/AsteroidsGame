using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ScoreBehavior : MonoBehaviour
{
    public int score;
    public UnityEvent<int> OnChangeScore;

    private void OnEnable()
    {
        ScoreUpdater.OnUpdateScore += AddScore;
    }

    private void OnDisable()
    {
        ScoreUpdater.OnUpdateScore -= AddScore;
    }

    private void Start()
    {
        restartScore();
    }

    public void AddScore(int d)
    {
        score += d;
        OnChangeScore.Invoke(score);
    }

    public void restartScore()
    {
        score = 0;
    }
}
