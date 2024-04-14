using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapController : MonoBehaviour
{
    private bool isActive;
    private int touchTimes;
    public int currentPosition;

    public FinishBehaviour finish;
    public PlayerKiller killer;
    public PauseMenuBehaviour pause;
    public Camera map, mainCam;
    public GameObject background, marker;

    public Vector3[] positions;
    public void ChangeMapPosition()
    {
        currentPosition++;

        map.transform.position = positions[currentPosition];
    }
    private void Start()
    {
        currentPosition = PlayerPrefs.GetInt("Save");
        map.transform.position = positions[currentPosition];
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M) && !pause.isPaused && !finish.IsWin && !killer.isDead)
        {
            map.gameObject.SetActive(!isActive);
            mainCam.gameObject.SetActive(isActive);
            marker.SetActive(!isActive);
            background.SetActive(isActive);

            touchTimes++;
            Time.timeScale = 0;

            isActive = true;
        }
        if (touchTimes == 2)
        {
            Time.timeScale = 1;
            touchTimes = 0;
            isActive = false;
        }
    }
}
