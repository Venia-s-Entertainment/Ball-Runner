using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreLogic : MonoBehaviour
{
    public Text score;
    public int totalScore;

    // Update is called once per frame
    void Update()
    {
        score.text = totalScore.ToString();
    }
}
