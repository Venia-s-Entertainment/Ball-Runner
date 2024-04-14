using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterVolumeScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Update()
    {
        AudioListener.volume = PlayerPrefs.GetFloat("MasterVolume");
    }

}
