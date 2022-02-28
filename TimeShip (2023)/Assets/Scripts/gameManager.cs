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

    //TMPro Texts
    public TextMeshProUGUI playerHealth;

    void Start()
    {
        player = player.GetComponent<Player>();
        //ghost = GetComponent<Renderer>();
    }

    void FixedUpdate(){
        playerHealth.text = "Health: " + player.hp;
    }

/*
    public IEnumerator whoTurn(int waitSec){
        waitSec /= 5;
        yield return new WaitForSecondsRealtime(waitSec);
        findTurn();
        StopCoroutine(whoTurn(0));

    }

    public void findTurn()
    {
        //turnText.text = whosTurn + " Turn";
        if (playerTurn == -1){
            whosTurn = "Enemy";
            turnText.text = whosTurn + " Turn";
        }

        else if (playerTurn == 0){
            whosTurn = "Enviroment";
            turnText.text = whosTurn + " Turn";
        }

        else if (playerTurn == 1) {
            whosTurn = "Your";
            turnText.text = whosTurn + " Turn";
            }
        //wait(waitSec);
    }
    */

    //Button Functions
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
