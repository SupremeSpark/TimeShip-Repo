using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class AttackSequence : ScriptableObject{
    //Attack Data (only accessible to AttackQueue.cs)
    public string attackName;
    public float timeStamp;
    //public float duration;

    //Bullet Data
    public float bulletDamage; //in BulletPhysics.cs
    public string effectApply; //not made status effects
    public float bulletLifetime; //in BulletPhysics.cs

    //Bullet Movement
    public float bulletSpeed; //in BulletSpawner.cs
    public float bulletAcceleration; //not implemented mid flight course correction
    
    //Turret Data
    public int numberOfBullets; //in BulletSpawner.cs
    public float rateOfFire; //in BulletSpawner.cs
    public GameObject bulletPrefab; //in BulletSpawner.cs
    public bool isRandom; //in BulletSpawner.cs

    //Starting Rotation
    public float minRotation; //in BulletSpawner.cs
    public float maxRotation; //in BulletSpawner.cs 
    
    //Rotation Over Time (Rotation over time not made yet)
    //public List<float> RminRotation; //in BulletSpawner.cs
    //public List<float> RmaxRotation; //in BulletSpawner.cs

}
