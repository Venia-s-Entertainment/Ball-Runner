using System;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour
{
    public Slider slider;
    public Text percent;

    private float value;
    //Volume changer//
    public void ChangeMusicVol()
    {
        PlayerPrefs.SetFloat("MusicVolume", slider.value);
    }
    public void ChangeEffectVol()
    {
        PlayerPrefs.SetFloat("EffectsVolume", slider.value);
    }
    public void ChangeMasterVol()
    {
        PlayerPrefs.SetFloat("MasterVolume", slider.value);
    }

    private void Start()
    {
        if (gameObject.CompareTag("AudioEffect"))
        {
            slider.value = PlayerPrefs.GetFloat("EffectsVolume");
        }
        if (gameObject.CompareTag("Music"))
        {
            slider.value = PlayerPrefs.GetFloat("MusicVolume");
        }
        if (gameObject.CompareTag("MasterVolume"))
        {
            slider.value = PlayerPrefs.GetFloat("MasterVolume");
        }      
    }
    private void Update()
    {
        value = slider.value * 100;
        percent.text = $"{Convert.ToInt32(value)}%";
    }
}
