using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using TMPro;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;
    private float visualVolume;
    [SerializeField] private TextMeshProUGUI volumeTXT;

    public void Start(){
        audioMixer.SetFloat("MasterVolume", -20);
    }

    public void SetVolume (float volume){
        audioMixer.SetFloat("MasterVolume", volume);
        visualVolume = volume + 80;
        volumeTXT.text = "Volume: " + Mathf.Round(visualVolume) + "%";
    }
    public void SetQuality (int qualityIndex){
       QualitySettings.SetQualityLevel(qualityIndex);
    }
    public void SetFullscreen (bool isFullscreen){
       Screen.fullScreen = isFullscreen;
    }
}
