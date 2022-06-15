using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossManager : PlayerManager
{
    public playerBulletPhysics playerBulletPhysics;

    protected override void OnTriggerEnter(Collider collision){
        if (collision.tag == "PlayerBullets" && hitTimer <= 0){
            hp -= playerBulletPhysics.damage();
            hitTimer = hitCooldown;
        }
    }
    
    protected override void HealthCheck(){
        if (hp == 0){
            Destroy(gameObject);
        }
    }
}
