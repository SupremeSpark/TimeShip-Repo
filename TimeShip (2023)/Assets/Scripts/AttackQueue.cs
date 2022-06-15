using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackQueue : MonoBehaviour
{
    //establish connections
    private gameManager gameManager;
    public BulletSpawner bulletSpawner;

    //stuff
    [SerializeField] private List<AttackSequence> attackQueue;


    void Start(){
        //reset
        StopAllCoroutines();     

        //find scripts
        gameManager = GameObject.Find("GameManager").GetComponent<gameManager>();
    }

    void FixedUpdate() {
        //loop through queue list
        for (int i = 0; i < attackQueue.Count; i++) {
            if (Mathf.Round(gameManager.elapsedTime) == attackQueue[i].timeStamp){
                executeAttack(attackQueue[i]);

                //StartCoroutine(waitSec(attackQueue[i].duration));
            }
        }
    }

    public void executeAttack(AttackSequence attack){
        //Bullet Data
        //bulletDamage; //in BulletPhysics.cs
        //effectApply; //not made status effects
        //bulletLifetime; //in BulletPhysics.cs

        //Bullet Movement
        bulletSpawner.bulletSpeed = attack.bulletSpeed; //in BulletSpawner.cs
        //bulletAcceleration; //not implemented mid flight course correction
    
        //Turret Data
        //bulletSpawner.numberOfBullets = attack.numberOfBullets;
        bulletSpawner.rateOfFire = attack.rateOfFire;
        bulletSpawner.bulletPrefab = attack.bulletPrefab;
        bulletSpawner.isRandom = attack.isRandom;

        //Starting Rotation
        bulletSpawner.minRotation = attack.minRotation;
        bulletSpawner.maxRotation = attack.maxRotation;

        //Rotation over time (Not implemented)
        //minRotation;
        //maxRotation;
    }
    
    IEnumerator waitSec(float duration){
        yield return new WaitForSeconds(duration);
    }
}