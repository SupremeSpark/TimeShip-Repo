using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopHPManager : PlayerManager
{
    protected override void HealthCheck(){
        if (hp == 0){
            Destroy(gameObject);
        }
    }
}
