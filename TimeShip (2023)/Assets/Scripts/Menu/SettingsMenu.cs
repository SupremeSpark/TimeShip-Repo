using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using TMPro;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;
    private float visualVolume;
    [SerializeField] private TextMeshProUGUI volumeTXT;
    Resolution[] resolutions;
    public TMP_Dropdown resolutionsDropdown;

    public void Start(){
//sets recommedned volume
        audioMixer.SetFloat("MasterVolume", -20);
//resolution stuff
        resolutions = Screen.resolutions;
        resolutionsDropdown.ClearOptions();
        List<string> options = new List<string>();

        int currentResolutionIndex = 0;

        //loops for available resolutions
        for (int i = 0; i < resolutions.Length; i++){
            string option = resolutions[i].width + "x" + resolutions[i].height;
            options.Add(option);
            //finds recommedned resolution
            if (resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height){
                currentResolutionIndex = i;
            }
        }

        //adds a vailable resolutions
        resolutionsDropdown.AddOptions(options);
        resolutionsDropdown.RefreshShownValue();
        //sets recommedned resolution
        resolutionsDropdown.value = currentResolutionIndex;
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
    public void SetResolution (int resolutionIndex){
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }
}
