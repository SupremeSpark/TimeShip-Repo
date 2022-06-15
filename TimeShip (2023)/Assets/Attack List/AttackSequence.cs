using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class AttackSequence : ScriptableObject{
    //Attack Data (only accessible to AttackQueue.cs)
    public string attackName; //Works, can be printed when needed
    public float timeStamp; //Works, timestamp is correctly compared with elapsed time to queue changes

    //Bullet Data
    public float bulletDamage; //Works, dmg is stored in the bullet, then calculated within the dmg reciever
    public string effectApply; //Not made status effects
    public float bulletLifetime;

    //Bullet Movement
    public float bulletSpeed; //Works, The bullets fired after the changes are the only ones affected

    public float bulletAcceleration; //Not implemented midflight course correction
    public GameObject target; //Not implemented midflight course correction

    
    //Turret Data (Works as intended)
    public int numberOfBullets;
    public float rateOfFire;
    public GameObject bulletPrefab;
    public bool isRandom;

    //Starting Rotation (Works as intended)
    public float minRotation;
    public float maxRotation;
    
    //Rotation Over Time (Not made yet)
    //public List<float> RminRotation; //in BulletSpawner.cs
    //public List<float> RmaxRotation; //in BulletSpawner.cs
}
