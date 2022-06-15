using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
//changeables
    //Bullet Data
    public float bulletDamage; //in BulletPhysics.cs | Not implemented
    public string effectApply; //not made status effects
    public float bulletLifetime; //in BulletPhysics.cs | Not implemented

    //Bullet Movement
    public float bulletSpeed;
    public Vector3 bulletAcceleration; //not implemented mid flight course correction
    
    //Turret Data 
    public int numberOfBullets;
    public float rateOfFire;
    public GameObject bulletPrefab;
    public bool isRandom;

    //Starting Rotation
    public float minRotation;
    public float maxRotation;
    
    //Rotation Over Time
    //Not made yet

    //constants
    float[] rotations;
    float timer;

    void Start()
    {
        timer = rateOfFire;
        rotations = new float[numberOfBullets];
        if (!isRandom)
        {
            //This doesn't need to be in update because the rotations will be the same no matter what
            //Unless if we change min Rotation and max Rotation Variables leave this in Start.
            DistributedRotations();
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (timer <= 0)
        {
            SpawnBullets();
            timer = rateOfFire;
        }
        timer -= Time.deltaTime;
    }

    // Select a random rotation from min to max for each bullet
    public float[] RandomRotations()
    {
        for (int i = 0; i < numberOfBullets; i++)
        {
            rotations[i] = Random.Range(minRotation, maxRotation);
        }
        return rotations;

    }
    
    // This will set random rotations evenly distributed between the min and max Rotation.
    public float[] DistributedRotations()
    {
        for (int i = 0; i < numberOfBullets; i++)
        {
            var fraction = (float)i / ((float)numberOfBullets - 1);
            var difference = maxRotation - minRotation;
            var fractionOfDifference = fraction * difference;
            rotations[i] = fractionOfDifference + minRotation; // We add minRotation to undo Difference
        }
        return rotations;
    }
    public GameObject[] SpawnBullets(){
        if (isRandom){
            RandomRotations();
        }

        // Spawn Bullets
        GameObject[] spawnedBullets = new GameObject[numberOfBullets];
        for (int i = 0; i < numberOfBullets; i++){
            spawnedBullets[i] = Instantiate(bulletPrefab, transform);

            var b = spawnedBullets[i].GetComponent<enemyBulletPhysics>();

//---------------------------------------change bullet settings----------------------------------------------------------------------------
            //Don't effect this one
            b.rotation = rotations[i];

            //Bullet Movement
            b.bulletSpeed = bulletSpeed;
            b.bulletAcceleration = bulletAcceleration;

            //Bullet Data
            b.bulletDamage = bulletDamage;
            b.effectApply = effectApply;
            b.bulletLifetime = bulletLifetime;
        }
        return spawnedBullets;
    }

}