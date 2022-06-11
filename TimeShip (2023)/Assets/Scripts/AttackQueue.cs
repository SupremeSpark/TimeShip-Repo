using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackQueue : MonoBehaviour
{
    //establish connections
    private gameManager gameManager;

    //stuff
    public List<AttackSequence> attackQueue;


    void Start(){
        gameManager = GameObject.Find("GameManager").GetComponent<gameManager>();
    }

    void Update() {
        for (int i = 0; i < attackQueue.Count; i++)
        {
            if (Mathf.Round(gameManager.elapsedTime) >= attackQueue[i].timeStamp){
                executeAttack(attackQueue[i]);
            }
            //add corotine to wait duration here
        }
    }

    public void executeAttack(AttackSequence a){
        //TODO

        //return/output changes here
        //return null
    }
}

//lmao i'm writting code while in an airplane lets goooo