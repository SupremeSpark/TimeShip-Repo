using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBulletPhysics : BulletPhysics
{
    public override void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Enemy") return;
        if (other.gameObject.tag == "EnemyBullets") return;
        {
            Destroy(gameObject);
        }
    }
}