using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
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

    private void CheckDeath()
    {
        if(health <= 0)
        {
            Score.scorevalue += 10;
            Destroy(gameObject);
        }
    }
}
