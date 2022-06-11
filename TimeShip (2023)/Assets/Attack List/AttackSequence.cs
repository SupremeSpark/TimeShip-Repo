using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class AttackSequence : ScriptableObject
{
    //Queue Data
    public float timeStamp;
    public float duration;

    //Bullet Data
    public float bulletDamage;
    public string effectApply;

    //Bullet movement
    public float bulletSpeed; //in BulletSpawn.cs
    public float bulletAcceleration;
    
    //Turret Data
    public int numberOfBullets; //in BulletSpawner.cs
    public float rateOfFire; //in BulletSpawner.cs
    public GameObject bulletPrefab; //in BulletSpawner.cs
    public bool isRandom; //in BulletSpawner.cs
    public float bulletLifetime;
    public List<Quaternion> rotationOverTime;
}
