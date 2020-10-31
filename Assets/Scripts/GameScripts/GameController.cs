using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [Header("Score Info")]
    public Text scoreText;
    public int score;

    [Header("Timer")]
    public Text timerText;
    public float timer;

    void Start()
    {
        ScoreUI();
        TimerUI();
    }

    // Update is called once per frame
    void Update()
    {
        //Text UI
        ScoreUI();
        TimerUI();
    }

    void ScoreUI()
    {
        scoreText.text = "Score: " + score;
    }

    void TimerUI()
    {
        timerText.text = "Time: " + timer;
    }
}
