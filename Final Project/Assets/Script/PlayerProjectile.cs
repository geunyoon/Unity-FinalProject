﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProjectile : MonoBehaviour
{
    public float damage;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name != "Player")
        {
            if(collision.GetComponent<Enemy>() != null)
            {
                collision.GetComponent<Enemy>().DealDamage(damage);
            }
            Destroy(gameObject);
        }
    }
}
