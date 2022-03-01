using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    [SerializeField] private GameObject bulletResource;
    [SerializeField] private float minRotation;
    [SerializeField] private float maxRotation;
    [SerializeField] private int numberOfBullets;
    [SerializeField] private bool isRandom;

    [SerializeField] private float cooldown;
    [SerializeField] float timer;
    [SerializeField] private float bulletSpeed;
    [SerializeField] private Vector3 bulletVelocity;


    float[] rotations;
    void Start()
    {
        timer = cooldown;
        rotations = new float[numberOfBullets];
        if (!isRandom)
        {
            /* 
             * This doesn't need to be in update because the rotations will be the same no matter what
             * Unless if we change min Rotation and max Rotation Variables leave this in Start.
             */
            DistributedRotations();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (timer <= 0)
        {
            SpawnBullets();
            timer = cooldown;
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
    public GameObject[] SpawnBullets()
    {
        if (isRandom)
        {
            RandomRotations();
        }

        // Spawn Bullets
        GameObject[] spawnedBullets = new GameObject[numberOfBullets];
        for (int i = 0; i < numberOfBullets; i++)
        {
            spawnedBullets[i] = Instantiate(bulletResource, transform);

    
            var b = spawnedBullets[i].GetComponent<enemyBulletPhysics>();
            b.rotation = rotations[i];
            b.speed = bulletSpeed;
            b.velocity = bulletVelocity;
    
    
        }
        return spawnedBullets;
    }

}