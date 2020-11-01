using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    [Header("Game State Variables")]
    public int currentLevel;
    static int level = 1;
    public bool miniGameStarted;
    public bool gameOver;
    
    [Header("Score Info")]
    public Text scoreText;
    public int currentScore = 0;
    public static int totalScore = 0;

    [Header("Timer")]
    public Text timerText;
    public int timer = 30;
    private bool startTimer;

    void Start()
    {
        currentLevel = 1;

        //Text Setter
        ScoreUI();
        TimerUI();
    }

    // Update is called once per frame
    void Update()
    {

            //Text UI
            ScoreUI();
            TimerUI();

            //Starts timer countdown
            if (startTimer == false && timer > 0)
            {
                StartCoroutine(TimerStarts());
            }

        //Exits minigame when time runs out
        if (timer <= 0)
        {
            level++;
            currentLevel = level;
            gameOver = true;
            totalScore += currentScore;
            miniGameStarted = false;
            SceneManager.LoadScene(1);
        }
    }

    void ScoreUI()
    {
        scoreText.text = "Score: " + currentScore;
    }

    void TimerUI()
    {
        timerText.text = "00:" + timer;

        if(timer <10)
        {
            timerText.text = "00:0" + timer;
        }
    }

    IEnumerator TimerStarts()
    {
        startTimer = true;
        yield return new WaitForSeconds(1);
        timer -= 1;
        timerText.text = "00:" + timer;
        startTimer = false;
    }
}
