using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossManager : PlayerManager
{
    protected override void OnTriggerEnter(Collider collision){
        if (collision.tag == "PlayerBullets" && hitTimer <= 0){
            hp -= 1;
            hitTimer = hitCooldown;
        }
    }
    
    protected override void HealthCheck(){
        if (hp == 0){
            Destroy(gameObject);
        }
    }
}
