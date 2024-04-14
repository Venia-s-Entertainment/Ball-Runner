using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelChanger : MonoBehaviour
{
    public GameObject mainCam;
    public GameObject[] levels;
    public GameObject nextLevel;

    public FinishBehaviour finish;

    public float activeTime = 1;
    public int currentLevel;

    // Update is called once per frame

    private void Start()
    {
        currentLevel = PlayerPrefs.GetInt("Save");

        nextLevel = levels[currentLevel];
        transform.position = nextLevel.transform.position;

        nextLevel.SetActive(true);
    }
    public void OnChangeLevel()
    {          
        currentLevel++;

        mainCam.transform.SetParent(null);

        nextLevel = levels[currentLevel];
        transform.position = nextLevel.transform.position;

        nextLevel.SetActive(true);
    }
    public void OnRestartLevel()
    {
        nextLevel.SetActive(false);

        currentLevel--;

        nextLevel = levels[currentLevel];
        transform.position = nextLevel.transform.position;
    }
    private void Update()
    {
        if (finish.nextLevel)
        {
            activeTime -= Time.deltaTime;

            if (activeTime < 0)
            {
                activeTime = 1;

                nextLevel = levels[currentLevel - 1];
                nextLevel.SetActive(false);

                finish.nextLevel = false;
            }
            
        }
    }
}
