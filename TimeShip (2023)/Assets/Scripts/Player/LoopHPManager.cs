using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopHPManager : Player
{
    public override void TerminateLoop(){
        Destroy(gameObject);
    }
}
