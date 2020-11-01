using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public int level;

    public bool miniGameStarted;
    
    [Header("Score Info")]
    public Text scoreText;
    public int score = 0;

    [Header("Timer")]
    public Text timerText;
    public int timer = 30;
    private bool startTimer;

    void Start()
    {
        //Level Setter
        level = 1;

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
        if(startTimer == false && timer > 0)
        {
            StartCoroutine(TimerStarts());
        }

        //Exits minigame when time runs out
        if(timer <= 0)
        {
            miniGameStarted = false;
            SceneManager.LoadScene(1);
            level++;
        }
    }

    void ScoreUI()
    {
        scoreText.text = "Score: " + score;
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
