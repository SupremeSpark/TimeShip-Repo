using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPhysics : MonoBehaviour{
    //establish contants
    public float rotation; 

    //Bullet Data
    public float bulletDamage;
    public string effectApply; //not made status effects
    public float bulletLifetime;

    //Bullet Movement
    public float bulletSpeed; //in BulletSpawner.cs
    public Vector3 bulletAcceleration; //not implemented mid flight course correction

    public float damage(){
        return bulletDamage;
    }

    public virtual void Start(){
        transform.rotation = Quaternion.Euler(0, rotation, 0);
        StartCoroutine(DestoryBulletAfterTime());
    }

    void FixedUpdate(){
        transform.Translate(Vector3.forward * bulletSpeed * Time.deltaTime);
    }

    public virtual void OnTriggerEnter(Collider other) {
        //Put things it will ignore
        //Put what it will do upon impact (explode/aoe dmg | multiply | bounce | destory itself and/or destory other bullets|)
    }
    public IEnumerator DestoryBulletAfterTime(){
        yield return new WaitForSeconds(bulletLifetime);
        Destroy(gameObject);
    }
}