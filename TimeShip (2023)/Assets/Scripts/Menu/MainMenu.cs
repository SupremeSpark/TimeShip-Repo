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
    public void QuitGame(){
        Debug.Log("Quit");
        Application.Quit();
    }

    public void ChangeScene(string sceneName){
        LevelManager.Instance.LoadScene(sceneName);
    }

}
