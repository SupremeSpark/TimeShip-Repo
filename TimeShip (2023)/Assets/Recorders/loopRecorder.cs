using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loopRecorder : MonoBehaviour
{
    //loop datas
    public looper looper1;
    public looper looper2;
    public looper looper3;
    public looper looper4;

    private float timer;
    private float timeValue;
    public static int loopNumber = 0;
    //establish stuffs
    private gameManager gameManager;


    private void Awake()
    {
        loopNumber++;
        if (CurrentLooper(loopNumber).isRecord)
        //if (looper1.isRecord)
        {
            timeValue = 0;
            timer = 0;
        }
    }

    private void Start(){
        gameManager = GameObject.Find("GameManager").GetComponent<gameManager>();
    }

    // Update is called once per frame
    void Update(){
        RecordLoop(CurrentLooper(loopNumber));
        //RecordLoop(looper1);
    }

    public looper CurrentLooper(int loopNum){
        switch(loopNum){
            case 1: 
                return looper1;
            case 2:
                return looper2;
            case 3:
                return looper3;
            case 4:
                return looper4;
            default:
                return null;
        }
    }

    void RecordLoop(looper looper){
        
        timer += Time.unscaledDeltaTime;
        timeValue += Time.unscaledDeltaTime;

        if (looper.isRecord & timer >= 1/looper.recordFrequancy)
        {

            looper.timeStamp.Add(timeValue);
            looper.position.Add(this.transform.position);
            looper.rotation.Add(this.transform.eulerAngles);

            timer = 0;
        }
    }
}