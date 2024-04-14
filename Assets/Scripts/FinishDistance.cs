using System;
using UnityEngine;
using UnityEngine.UI;

public class FinishDistance : MonoBehaviour
{
    public GameObject player, finish, finishDistance;
    public Text text;
    private bool isEnabled;

    // Update is called once per frame
    void Update()
    {
        isEnabled = Convert.ToBoolean(PlayerPrefs.GetInt("Finish"));

        if (isEnabled)
        {
            finishDistance.SetActive(true);

            text.text = $"{Convert.ToInt32(Vector2.Distance(finish.transform.position, player.transform.position))}m";
        }
        else
        {
            finishDistance.SetActive(false);
        }
    }
}
