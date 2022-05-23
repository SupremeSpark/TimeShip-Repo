using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
        [SerializeField] public Image _hpsprite;

    public void UpdateHealth(float maxHealth, float currentHealth){
        _hpsprite.fillAmount = maxHealth / currentHealth;
    }
}