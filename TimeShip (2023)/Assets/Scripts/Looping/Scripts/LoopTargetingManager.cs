using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopTargetingManager : TargetingController
{
    //overiding these cuz they give me bugs
    override protected void OnEnable(){}
    override protected void OnDisable(){}
    public override void Awake(){}
    override public void Start(){}
    override public void Update(){}
    override public void TimeShipShoot(){
        GameObject g = Instantiate(bullet, bulletDirection.position, bulletDirection.rotation, BulletPool);
        //g.SetActive(true);
    }
}
