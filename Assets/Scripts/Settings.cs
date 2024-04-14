using System;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    public GameObject success;
    public Toggle toggleFPS, Finish, vSynch;
    public Dropdown dropdownFPS, screenMode, screenResolution;

    public void DeleteSave()
    {
        PlayerPrefs.DeleteKey("Save");

        success.SetActive(true);
    }
    public void ShowFPS()
    {
        PlayerPrefs.SetInt("toggleFps", Convert.ToInt32(toggleFPS.isOn));
    }
    public void ShowDistanceToFinish()
    {
        PlayerPrefs.SetInt("Finish", Convert.ToInt32(Finish.isOn));
    }
    public void MinFPS()
    {
        PlayerPrefs.SetInt("dropdownFPS", dropdownFPS.value);
    }
    public void SreenMode()
    {
        PlayerPrefs.SetInt("screenMode", screenMode.value);
    }
    public void ScreenResolution()
    {
        PlayerPrefs.SetInt("screenResolution", screenResolution.value);
    }
    public void VerticalSynchranization()
    {
        PlayerPrefs.SetInt("VSynch", Convert.ToInt32(vSynch.isOn));
    }
    private void Start()
    {
        toggleFPS.isOn = Convert.ToBoolean(PlayerPrefs.GetInt("toggleFps"));
        Finish.isOn = Convert.ToBoolean(PlayerPrefs.GetInt("Finish"));
        vSynch.isOn = Convert.ToBoolean(PlayerPrefs.GetInt("VSynch"));

        dropdownFPS.value = PlayerPrefs.GetInt("dropdownFPS");
        screenMode.value = PlayerPrefs.GetInt("screenMode");
        screenResolution.value = PlayerPrefs.GetInt("screenResolution");
    }
}
