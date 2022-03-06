using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loopPlayer : MonoBehaviour
{
    public looper looper;
    private float timeValue;
    private int index1;
    private int index2;
    //shooting variables
    //this should be LoopTargetingManager
    private TargetingController targetingController;


    private void Awake()
    {
        timeValue = 0;
        //this should be find looper# and LoopTargetingManager
        targetingController = GameObject.Find("Player").GetComponent<TargetingController>();
    }


    void Update()
    {
        //deletes ship when it no longer has data to replay (prev loop ship died)
/*
        if (index2 == looper.timeStamp.Count) {
            Destroy(gameObject);
        }
*/
        timeValue += Time.unscaledDeltaTime;
        //replays loop
        if (looper.isReplay)
        {
            GetIndex();
            SetTransform();
            //FireShots();
        }
    }
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

    /*
    private void FireShots(){
        //this should be LoopTargetingManager.TimeShipShoot();
        targetingController.TimeShipShoot();
    }
    */



}
