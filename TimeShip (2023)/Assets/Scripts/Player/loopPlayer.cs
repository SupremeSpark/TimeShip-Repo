using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loopPlayer : MonoBehaviour
{
    public looper looper;
    private float timeValue;
    private int index1;
    private int index2;
    private void Awake()
    {
        timeValue = 0;
    }


    void Update()
    {
        timeValue += Time.unscaledDeltaTime;

        if (looper.isReplay)
        {
            GetIndex();
            SetTransform();
        }
    }
    private void GetIndex()
    {
        for (int i = 0; i < looper.timeStamp.Count - 2; i++)
        {
            if (looper.timeStamp[i] == timeValue)
            {
                index1 = i;
                index2 = 1;
                return;
            }
            else if (looper.timeStamp[i] < timeValue & timeValue < looper.timeStamp[i + 1])
            {
                index1 = i;
                index2 = i + 1;
                return;
            }
        }

        index1 = looper.timeStamp.Count - 1;
        index2 = looper.timeStamp.Count - 1;

    }
    private void SetTransform()
    {
        if (index1 == index2)
        {
            this.transform.position = looper.position[index1];
            this.transform.eulerAngles = looper.rotation[index1];
        }
        else
        {
            float interpolationFactor = (timeValue-looper.timeStamp[index1])/(looper.timeStamp[index2]-looper.timeStamp[index1]);

            this.transform.position = Vector3.Lerp(looper.position[index1], looper.position[index2], interpolationFactor);
            this.transform.eulerAngles = Vector3.Lerp(looper.rotation[index1], looper.rotation[index2], interpolationFactor);
        }
    }



}
