using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackQueue : MonoBehaviour
{
    public List<AttackSequence> attackQueue;
    public float elapsedTime;

    void FixedUpdate(){
        //elapsedTime += Time.deltatime;
    }

    void Update() {
        for (int i = 0; i < 10; i++) //add length of list instead of 10
        {
            /*
            if (elapsedTime == attackQueue(i).timeStamp){ //find out how to access lists
                executeAttack(attackQueue(i)); //find out how to access lists
            }
            */

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