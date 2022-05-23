using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Establish Objects
    [SerializeField] private float hitCooldown;
    float hitTimer;
    private gameManager gameManager;
    [SerializeField] private HealthBar HealthBar;
    private PlayerActions controls;

    //Stats
    [SerializeField] private float startHP;
    public float hp;
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<gameManager>();
        hp = startHP;
        HealthBar.UpdateHealthBar(hp, startHP);
    }

    void FixedUpdate()
    {
        hitTimer -= Time.deltaTime;
        HealthBar.UpdateHealthBar(hp, startHP);
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
            TerminateLoop();
        }
    }

    public virtual void TerminateLoop(){
        Destroy(gameObject);
        gameManager.RestartScene();
    }

}
