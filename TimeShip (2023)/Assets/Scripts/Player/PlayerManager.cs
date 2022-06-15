using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    //Establish Objects
    [SerializeField] protected float hitCooldown;
    protected float hitTimer;

    //Establish connections
    [SerializeField] private HealthBar HealthBar;
    private PlayerActions controls;
    public enemyBulletPhysics enemyBulletPhysics;
    private gameManager gameManager;

    //Stats
    public float startHP;
    public float hp;

    void Awake(){
        hp = startHP;
    }

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<gameManager>();
    }

    void FixedUpdate()
    {
        hitTimer -= Time.deltaTime;
        HealthBar.UpdateHealthBar(startHP, hp);
        HealthCheck();
    }

    protected virtual void OnTriggerEnter(Collider collision){
        if (collision.tag == "EnemyBullets" && hitTimer <= 0){
            hp -= enemyBulletPhysics.damage();
            hitTimer = hitCooldown;
        }
    }

    protected virtual void HealthCheck(){
        if (hp == 0){
            Destroy(gameObject);
            gameManager.RestartScene();
        }
    }
}
