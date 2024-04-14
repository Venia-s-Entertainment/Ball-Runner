using System;
using UnityEngine;

public class GameConfig : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        //Screen Rsolution//

        if (PlayerPrefs.GetInt("screenResolution") == 0)
        {
            Screen.SetResolution(3840, 2160, Screen.fullScreenMode);
        }
        if (PlayerPrefs.GetInt("screenResolution") == 1)
        {
            Screen.SetResolution(2560, 1440, Screen.fullScreenMode);
        }
        if (PlayerPrefs.GetInt("screenResolution") == 2)
        {
            Screen.SetResolution(1920, 1080, Screen.fullScreenMode);
        }
        if (PlayerPrefs.GetInt("screenResolution") == 3)
        {
            Screen.SetResolution(1536, 864, Screen.fullScreenMode);
        }
        if (PlayerPrefs.GetInt("screenResolution") == 4)
        {
            Screen.SetResolution(1366, 786, Screen.fullScreenMode);
        }
        if (PlayerPrefs.GetInt("screenResolution") == 5)
        {
            Screen.SetResolution(1280, 720, Screen.fullScreenMode);
        }

        
        //Fps border//
        if (Convert.ToInt32(PlayerPrefs.GetInt("VSynch")) == 1)
        {
            Debug.Log("VSync working");

            Application.targetFrameRate = 0;
            QualitySettings.maxQueuedFrames = 2;
            QualitySettings.vSyncCount = 1;
        }
        if (Convert.ToInt32(PlayerPrefs.GetInt("VSynch")) == 0)
        {
            Debug.Log("VSync stop working");

            QualitySettings.vSyncCount = 0;
            QualitySettings.maxQueuedFrames = 0;
        }

        if (PlayerPrefs.GetInt("dropdownFPS") == 0 && QualitySettings.vSyncCount == 0)
        {
            Application.targetFrameRate = 240;
        }
        if (PlayerPrefs.GetInt("dropdownFPS") == 1 && QualitySettings.vSyncCount == 0)
        {
            Application.targetFrameRate = 120;
        }
        if (PlayerPrefs.GetInt("dropdownFPS") == 2 && QualitySettings.vSyncCount == 0)
        {
            Application.targetFrameRate = 60;
        }
        if (PlayerPrefs.GetInt("dropdownFPS") == 3 && QualitySettings.vSyncCount == 0)
        {
            Application.targetFrameRate = 30;
        }
        if (PlayerPrefs.GetInt("dropdownFPS") == 4 && QualitySettings.vSyncCount == 0)
        {
            Application.targetFrameRate = 15;
        }

        //Full Screen Mode//

        if (PlayerPrefs.GetInt("screenMode") == 0)
        {
            Screen.fullScreenMode = FullScreenMode.ExclusiveFullScreen;
        }
        if (PlayerPrefs.GetInt("screenMode") == 1)
        {
            Screen.fullScreenMode = FullScreenMode.Windowed;
        }
    }
}
