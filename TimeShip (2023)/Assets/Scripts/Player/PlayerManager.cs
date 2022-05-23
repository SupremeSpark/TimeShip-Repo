using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    //Establish Objects
    [SerializeField] private float hitCooldown;
    float hitTimer;
    private gameManager gameManager;
    [SerializeField] private HealthBar _healthBar;
    private PlayerActions controls;

    //Stats
    [SerializeField] private int maxHP;
    [SerializeField] private int hp;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<gameManager>();
        _healthBar = GameObject.Find("Health Canvas").GetComponent<HealthBar>();
        hp = maxHP;
        _healthBar.UpdateHealth(maxHP, hp);
    }

    void FixedUpdate()
    {
        hitTimer -= Time.deltaTime;
        HealthCheck();

    }

    private void OnTriggerEnter(Collider collision){
        if (collision.tag == "EnemyBullets" && hitTimer <= 0){
            hp -= 1;
            hitTimer = hitCooldown;
            _healthBar.UpdateHealth(maxHP, hp);
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
