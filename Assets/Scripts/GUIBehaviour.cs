using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIBehaviour : MonoBehaviour
{
    public GameObject youWin, youLoose, exit, retry;
    public ButtonBehaviour buttonNextLevel, buttonRetry;

    public FinishBehaviour finish;
    public PlayerKiller killer;

    // Update is called once per frame
    void Update()
    {
        if (finish.wasWin)
        {
            youWin.SetActive(false);
            retry.SetActive(false);
            exit.SetActive(false);

            finish.IsWin = false;
        }
        if (killer.wasDead)
        {
            youWin.SetActive(false);
            youLoose.SetActive(false);
            retry.SetActive(false);
            exit.SetActive(false);

            killer.isDead = false;
        }

        if (finish.IsWin)
        {
            youWin.SetActive(true);
            retry.SetActive(true);
            exit.SetActive(true);
        }
        if (killer.isDead)
        {
            youLoose.SetActive(true);
            retry.SetActive(true);
            exit.SetActive(true);
        }
    }
}
