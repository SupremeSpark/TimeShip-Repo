using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Establish Objects
    [SerializeField] private float hitCooldown;
    float hitTimer;
    private gameManager gameManager;
    private PlayerActions controls;

    //Stats
    [SerializeField] private int startHP;
    public int hp;
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<gameManager>();
        hp = startHP;
    }

    void Update()
    {
        hitTimer -= Time.deltaTime;
        HealthCheck();

    }

    private void OnTriggerEnter(Collider collision){
        if (collision.tag == "EnemyBullets" && hitTimer <= 0){
            hp -= 1;
            hitTimer = hitCooldown;
        }
    }

    private void HealthCheck(){
        if (hp == 0){
            Destroy(gameObject);
            gameManager.RestartScene();
        }
    }

}
