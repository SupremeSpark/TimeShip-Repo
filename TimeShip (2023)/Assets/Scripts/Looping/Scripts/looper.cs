using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class looper : ScriptableObject
{
    public bool isRecord;
    public bool isReplay;
    //database list
    public List<float> timeStamp;
    public List<Vector3> position;
    public List<Vector3> rotation;
    public List<bool> isShooting;

    public void ResetData()
    {
        timeStamp.Clear();
        position.Clear();
        rotation.Clear();
        isShooting.Clear();
    }
}
