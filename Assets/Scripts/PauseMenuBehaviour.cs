using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuBehaviour : MonoBehaviour
{
    public GameObject pause, retryButton, exitButton;
    public FinishBehaviour finish;
    public TimeLogic time;
    public ScoreLogic score;
    public PlayerKiller killer;
    public ButtonBehaviour button;
    public LevelChanger levelChanger;

    private bool isActive;
    public bool isPaused;
    public bool Restart;
    public int touchTimes;

    // Update is called once per frame
    void Update()
    {
        if (button.retry && isPaused)
        {
            levelChanger.OnChangeLevel();
            levelChanger.OnRestartLevel();

            pause.SetActive(false);
            retryButton.SetActive(false);
            exitButton.SetActive(false);

            Time.timeScale = 1;

            isPaused = false;
            Restart = true;

            score.totalScore = 0;
            time.totalTime = 0;

            button.retry = false;
        }
        if (Input.GetKeyDown(KeyCode.Escape) && !finish.IsWin && !killer.isDead)
        {
            retryButton.SetActive(!isActive);
            exitButton.SetActive(!isActive);
            pause.SetActive(!isActive);

            touchTimes++;
            Time.timeScale = 0;
            isPaused = true;
        }
        if (touchTimes == 2)
        {
            Time.timeScale = 1;
            touchTimes = 0;
            isPaused = false;
        }
    }
}
