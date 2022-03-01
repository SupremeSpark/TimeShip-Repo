using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    //establish stuff
    public Player player;
    public int waitSec = 1;
    public looper looper;
    private PlayerActions controls;

    //TMPro Texts
    public TextMeshProUGUI playerHealth;
    //boss enable
    public GameObject BossTurret;
    private int turrets;
    //Enable/Disable stuff
    private void OnEnable(){controls.Enable();}
    private void OnDisable(){controls.Disable();}
    private void Awake(){
        controls = new PlayerActions();
        controls.ShipControl.LoopDie.performed += _ => Loop();
        controls.ShipControl.Hardreset.performed += _ => FullReset();
    }
    void Start()
    {
        player = player.GetComponent<Player>();
    }

    void FixedUpdate(){
        playerHealth.text = "Health: " + player.hp;
    }

    //enable level
    public void StartFight(){
        BossTurret.SetActive(true);
    }

    //Looping
    public void FullReset(){
        RestartScene();
        isReset();
        ResetData();
    }

    public void Loop(){
        RestartScene();
        looper.isReplay = true;
        Debug.Log("Looping");
    }
    public void RestartScene() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); }
    
    public void isRecording () {
        looper.isRecord = true;
        looper.isReplay = false;
    }
    public void isPlaying () {
        //ghost.enabled = true;
        looper.isRecord = false;
        looper.isReplay = true;
        
    }
    public void isReset(){
        looper.isRecord = false;
        looper.isReplay = false; 
    }
    public void ResetData()
    {
        looper.timeStamp.Clear();
        looper.position.Clear();
        looper.rotation.Clear();
    }
}
