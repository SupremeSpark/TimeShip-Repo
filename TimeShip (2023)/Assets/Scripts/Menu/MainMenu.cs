using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    void Awake(){
    }

    void Start(){
    }
    public void PlayGame(){
        SceneManager.LoadScene("H.A.R.BY");
    }

    public void GoMainMenu(){
        SceneManager.LoadScene("Main Menu");
    }
    public void QuitGame(){
        Debug.Log("Quit");
        Application.Quit();
    }
}
