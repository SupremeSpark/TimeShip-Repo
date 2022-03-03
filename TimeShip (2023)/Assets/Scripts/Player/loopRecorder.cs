using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loopRecorder : MonoBehaviour
{
    public looper looper;
    private float timer;
    private float timeValue;
    private void Awake()
    {
        if (looper.isRecord)
        {
            timeValue = 0;
            timer = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
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
