using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    //establish stuff
    private PlayerManager playerManager;
    private loopRecorder loopRecorder;

    //loop data recorders
    [SerializeField] private looper looper1;
    [SerializeField] private looper looper2;
    [SerializeField] private looper looper3;
    [SerializeField] private looper looper4;

    private PlayerActions controls;

    //TMPro Texts
    //[SerializeField] private  TextMeshProUGUI playerHealthTXT;
    [SerializeField] private  TextMeshProUGUI loopNumberTXT;

    //Enable/Disable stuff
    private void OnEnable(){controls.Enable();}
    private void OnDisable(){controls.Disable();}
    private void Awake(){
        //controls
        controls = new PlayerActions();
        controls.ShipControl.LoopDie.performed += _ => RestartScene();
        controls.ShipControl.Hardreset.performed += _ => FullReset();
        controls.ShipControl.Mainmenu.performed += _ => OnMainMenuClick();
    }
    private void Start()
    {
        loopRecorder = GameObject.Find("Player").GetComponent<loopRecorder>();
        playerManager = GameObject.Find("Player").GetComponent<PlayerManager>();
    }

    private void FixedUpdate(){
        //UI Texts
        //playerHealthTXT.text = "Health: " + playerManager.hp;
        loopNumberTXT.text = "Loop #" + loopRecorder.loopNumber + " (L)";
        //time traveling
        RecordLoop();
        PlayLoops();
    }

    //records loops one at a time
    private void RecordLoop(){
        //stop all recordings
        looper1.isRecord = false;
        looper2.isRecord = false;
        looper3.isRecord = false;
        looper4.isRecord = false;
        switch(loopRecorder.loopNumber){
            case 1: 
                looper1.isRecord = true;
                break;
            case 2:
                looper2.isRecord = true;
                break;
            case 3:
                looper3.isRecord = true;
                break;
            case 4:
                looper4.isRecord = true;
                break;
            case 5:
                break;
            default:
                loopRecorder.loopNumber = 0;
                FullReset();
                break;
        }
    }
    //Main Menu Reseting
    private void OnMainMenuClick(){
        SceneManager.LoadScene("Main Menu");
        isReset();
        ResetData();
    }

    //plays all previous loops
    private void PlayLoops(){
        if (loopRecorder.loopNumber >= 2){
            looper1.isReplay = true;
        }
        if (loopRecorder.loopNumber >= 3){
            looper2.isReplay = true;
        }
        if (loopRecorder.loopNumber >= 4){
            looper3.isReplay = true;
        }
        if (loopRecorder.loopNumber >= 5){
            looper4.isReplay = true;
        }
    }

    //Looping
    public void FullReset(){
        RestartScene();
        isReset();
        ResetData();
    }

    public void GameReset(){
        ResetData();
        isReset();
    }

    public void Loop(){
        RestartScene();
        //looper.isReplay = true;
    }
    public void RestartScene() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void isReset(){
        looper1.isRecord = false;
        looper1.isReplay = false; 
        looper2.isRecord = false;
        looper2.isReplay = false; 
        looper3.isRecord = false;
        looper3.isReplay = false; 
        looper4.isRecord = false;
        looper4.isReplay = false; 
    }
    public void ResetData()
    {
        loopRecorder.loopNumber = 0;
        
        looper1.timeStamp.Clear();
        looper1.position.Clear();
        looper1.rotation.Clear();
        looper1.isShooting.Clear();

        looper2.timeStamp.Clear();
        looper2.position.Clear();
        looper2.rotation.Clear();
        looper2.isShooting.Clear();

        looper3.timeStamp.Clear();
        looper3.position.Clear();
        looper3.rotation.Clear();
        looper3.isShooting.Clear();

        looper4.timeStamp.Clear();
        looper4.position.Clear();
        looper4.rotation.Clear();
        looper4.isShooting.Clear();
    }
}