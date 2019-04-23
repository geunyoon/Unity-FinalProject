﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRecieveDamage : MonoBehaviour
{
    public float health;
    public float maxhealth;

    private void Start()
    {
        health = maxhealth;
    }

    public void DealDamage(float damage)
    {
        health -= damage;
        CheckDeath();
    }

    private void CheckOverheal()
    {
        if(health > maxhealth)
        {
            health = maxhealth;
        }
    }

    private void CheckDeath()
    {
        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
