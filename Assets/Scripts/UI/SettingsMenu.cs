using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;
    public MouseLook mouseLook;

    public void SetVolume (float volume)
    {
        audioMixer.SetFloat("volume", volume);

    }

    public void SetQuality (int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }
        
    public void Change()
    {
        Screen.fullScreen = !Screen.fullScreen;
    }


}


