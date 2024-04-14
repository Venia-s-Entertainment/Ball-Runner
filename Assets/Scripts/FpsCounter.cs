using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FpsCounter : MonoBehaviour
{
    public GameObject fps;
    public Text text;
    private float Seconds;
    private int Framerates;
    private bool isEnabled;

    // Update is called once per frame
    void Update()
    {
        isEnabled = Convert.ToBoolean(PlayerPrefs.GetInt("toggleFps"));

        if (isEnabled)
        {
            fps.SetActive(true);

            Seconds += Time.deltaTime;
            Framerates++;

            if (Seconds > 1)
            {
                text.text = Framerates.ToString();

                Seconds = 0;
                Framerates = 0;
            }
        }
        else
        {
            fps.SetActive(false);
        }
    }
}
