using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBulletPhysics : BulletPhysics
{
    public override void OnObjectSpawn(){
        transform.rotation = Quaternion.Euler(0, rotation, 0);
    }

    public override void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player") return;
        if (other.gameObject.tag == "EnemyBullets") return;
        {
            //Destroy(gameObject);
            //Destroy(other.gameObject);
        }
    }
}