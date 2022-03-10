using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loopPlayer : MonoBehaviour
{
    public looper looper;
    private float timeValue;
    private int timestamp;
    private int index1;
    private int index2;
    //shooting variables
    //this should be LoopTargetingManager
    private LoopTargetingManager loopTargetingManager;


    private void Awake()
    {
        timeValue = 0;
        //this should be find looper# and LoopTargetingManager
        loopTargetingManager = this.GetComponent<LoopTargetingManager>();
    }


    void Update()
    {
        timeValue += Time.unscaledDeltaTime;
        //replays loop
        if (looper.isReplay)
        {
            GetIndex();
            SetTransform();
            LoopShoot();
        }
    }

    //makes replay smoother by guessing the inbetweens
    private void GetIndex(){
        //grab 2 datapoints  
        for (int i = 0; i < looper.timeStamp.Count - 2; i++){
                if (looper.timeStamp[i] == timeValue){
                    index1 = i;
                    index2 = 1;
                    return;
                }
                else if (looper.timeStamp[i] < timeValue & timeValue < looper.timeStamp[i + 1]){
                    index1 = i;
                    index2 = i + 1;
                    return;
                }
        }

        index1 = looper.timeStamp.Count - 1;
        index2 = looper.timeStamp.Count - 1;

    }
    //sets rotation and position 
    private void SetTransform(){
        if (index1 == index2){
            this.transform.position = looper.position[index1];
            this.transform.eulerAngles = looper.rotation[index1];
        }
        else{
            float interpolationFactor = (timeValue-looper.timeStamp[index1])/(looper.timeStamp[index2]-looper.timeStamp[index1]);

            this.transform.position = Vector3.Lerp(looper.position[index1], looper.position[index2], interpolationFactor);
            this.transform.eulerAngles = Vector3.Lerp(looper.rotation[index1], looper.rotation[index2], interpolationFactor);
        }
    }
    //fires primary gun
    private void LoopShoot(){
        if (looper.isShooting[index1] == true) {
            Debug.Log("shooting from " + looper);
            this.loopTargetingManager.TimeShipShoot();     
        }
    }
}