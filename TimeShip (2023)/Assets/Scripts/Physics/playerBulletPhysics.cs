using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerBulletPhysics : BulletPhysics
{
    public override void OnObjectSpawn(){
        transform.rotation = Quaternion.Euler(0, rotation, 0);
    }

    public override void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player") return;
        if (other.gameObject.tag == "PlayerBullets") return;
        {
            //Destroy(gameObject);
            //Destroy(other.gameObject);
        }
    }
}
