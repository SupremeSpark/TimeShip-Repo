using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    //-1 = enemy turn, 0 bullets, events/bullets,  1 player turn
    public int playerTurn = -1;
    public TextMeshProUGUI turnText;
    public int waitSec = 1;
    public string whosTurn;
    public looper looper;
    private turnManager turnManager;
    //Starto
    void Start()
    {
        turnManager = GameObject.Find("GameManager").GetComponent<turnManager>();
    }

    void FixedUpdate(){
        StartCoroutine(whoTurn(waitSec));
    }

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
            turnManager.turnNum += 1;
            turnManager.updateText();
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

    //Button Functions
    public void RestartScene() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); }
    
    public void isRecording () {
        looper.isRecord = true;
        looper.isReplay = false;
    }
    public void isPlaying () {
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
