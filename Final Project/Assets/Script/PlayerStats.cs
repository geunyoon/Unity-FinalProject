using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    public static PlayerStats playerStats;

    public GameObject player;
    public Text healthText;
    public Slider healthSlider;

    public float health;
    public float maxhealth;

    private void Awake()
    {
        playerStats = this;
    }

    private void Start()
    {
        health = maxhealth;
        SetHealthUI();
    }

    public void DealDamage(float damage)
    {
        health -= damage;
        CheckDeath();
        SetHealthUI();
    }

    private void ChechOverHeal()
    {
        if(health > maxhealth)
        {
            health = maxhealth;
        }
    }

    private void SetHealthUI()
    {
        healthSlider.value = CalculateHealthPercentage();
        healthText.text = Mathf.Ceil(health).ToString() + " / " + Mathf.Ceil(maxhealth).ToString();
    }

    private void CheckDeath()
    {
        if (health <= 0)
        {
            health = 0;
            Destroy(player);
        }
    }
    
    float CalculateHealthPercentage()
    {
        return health / maxhealth;
    }
}
