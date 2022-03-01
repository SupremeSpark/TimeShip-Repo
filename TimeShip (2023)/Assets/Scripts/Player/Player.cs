using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Establish Objects
    [SerializeField] private int startHP;
    public int hp;
    [SerializeField] private float hitCooldown;
    float hitTimer;

    //Stats

    //Quality of life stuff

    void Start()
    {
        hp = startHP;
    }

    void Update()
    {
        hitTimer -= Time.deltaTime;
    }

    private void OnTriggerEnter(Collider collision){
        if (collision.tag == "EnemyBullets" && hitTimer <= 0){
            hp -= 1;
            hitTimer = hitCooldown;
        }
    }
}
