using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerBulletPhysics : BulletPhysics
{
    public override void Start(){
        StartCoroutine(DestoryBulletAfterTime());
    }

    public override void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player") return;
        if (other.gameObject.tag == "PlayerBullets") return;
        {
            Destroy(gameObject);
        }
    }
}
