using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class HealthBar : MonoBehaviour{
    [SerializeField] private Image _healthbarSprite;
    [SerializeField] private float reduceSpeed = 0.5f;
    private float target;
    private Camera cam;

    void Start(){
        cam = Camera.main;
    }

    public void UpdateHealthBar(float maxHealth, float currentHealth){
        target = currentHealth/maxHealth;
    }

    void Update(){
        transform.rotation = Quaternion.LookRotation(transform.position -  cam.transform.position);
        _healthbarSprite.fillAmount = Mathf.MoveTowards(_healthbarSprite.fillAmount, target, reduceSpeed * Time.deltaTime);
    }
}
