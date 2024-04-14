using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTransition : MonoBehaviour
{
    public GameObject player;
    public FinishBehaviour finish;
    public PlayerKiller killer;
    public PauseMenuBehaviour pauseMenu;

    private void FixedUpdate()
    {
        if (finish.wasWin || killer.wasDead || pauseMenu.Restart)
        {
            if (transform.position != player.transform.position)
            {
                transform.position = Vector2.MoveTowards(transform.position, player.transform.position, 3);
                transform.SetParent(player.transform);
                transform.position = new Vector3(transform.position.x, transform.position.y, 0);
            }
           
        }
        if (transform.position == player.transform.position)
        {
            finish.wasWin = false;
            killer.wasDead = false;
            pauseMenu.Restart = false;
        }
    } 
}
