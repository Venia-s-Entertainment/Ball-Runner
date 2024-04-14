using System;
using UnityEngine;
using UnityEngine.UI;

public class TimeLogic : MonoBehaviour
{
    public FinishBehaviour finish;
    public Text time;

    public float totalTime;
    private void Start()
    {
        totalTime = 0;
    }
    // Update is called once per frame
    void Update()
    {      
        if (finish.IsWin)
        {
            time.text = $"{Convert.ToInt32(totalTime)}s";
        }
        else
        {
            totalTime += Time.deltaTime;
        }               
    }
}
