using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    //Establish Objects
    [SerializeField] private float hitCooldown;
    float hitTimer;
    private gameManager gameManager;
    [SerializeField] private HealthBar HealthBar;
    private PlayerActions controls;

    //Stats
    public float startHP;
    public float hp;

    void Awake(){
        hp = startHP;
    }

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<gameManager>();
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

    protected virtual void HealthCheck(){
        if (hp == 0){
            Destroy(gameObject);
            gameManager.RestartScene();
        }
    }
}
