using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadlyWallBehaviour : MonoBehaviour
{
    public PlayerKiller killer;
    public LevelChanger levelchange;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            levelchange.OnChangeLevel();

            Time.timeScale = 0;
            killer.isDead = true;
        }    
    }
}
