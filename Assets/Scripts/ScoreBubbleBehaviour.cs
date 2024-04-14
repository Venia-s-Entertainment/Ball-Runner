using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBubbleBehaviour : MonoBehaviour
{
    public ScoreLogic score;
    public Vector2 oldPosition;
    public FinishBehaviour finish;
    public PlayerKiller killer;
    public PauseMenuBehaviour pause;
    public bool isCollected;

    private void Start()
    {
        oldPosition = gameObject.transform.position;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            score.totalScore += 50;

            gameObject.transform.position = new Vector2(10000, 10000);
        }
    }
    private void Update()
    {
        if (finish.IsWin || killer.isDead || pause.Restart)
        {
            gameObject.transform.position = oldPosition;
        }
        Debug.Log(pause.Restart);
    }
}
