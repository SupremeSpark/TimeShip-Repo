using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class AttackSequence : ScriptableObject
{
    //Turret Data
    public int numberOfBullets; //in BulletSpawner.cs
    public int rateOfFire; //in BulletSpawner.cs
    public GameObject bulletPrefab; //in BulletSpawner.cs
    public List<Quaternion> rotationOverTime;
    public bool isRandom; //in BulletSpawner.cs
    public float Duration;
    //Bullet Data
    public float bulletDamage;
    public string effectApply;
        //Bullet movement
    public float bulletSpeed; //in BulletSpawn.cs
    public float bulletAcceleration;
}
