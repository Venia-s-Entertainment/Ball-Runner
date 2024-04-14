using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerKiller : MonoBehaviour
{
    public bool isDead;
    public bool wasDead;
    public Camera cam;
    public ScoreLogic score;
    public ButtonBehaviour buttonRetry;
    public TimeLogic time;
    public LevelChanger levelchange;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            levelchange.OnChangeLevel();

            isDead = true;

            Time.timeScale = 0;
        }
    }
    private void Update()
    {
        if (buttonRetry.retry && isDead)
        {
            Time.timeScale = 1;

            score.totalScore = 0;
            time.totalTime = 0;

            levelchange.OnRestartLevel();

            wasDead = true;

            buttonRetry.retry = false;
        }

    }
}
