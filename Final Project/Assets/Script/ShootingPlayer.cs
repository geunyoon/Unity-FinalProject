using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingPlayer : EnemyAttack
{
    public GameObject projectile;
    public float minDamage;
    public float maxDamage; 
    public float projectileForce;
    public float cooldown;

    public override void Start()
    {
        base.Start();
        StartCoroutine(ShootPlayer());
    }

    IEnumerator ShootPlayer()
    {
        yield return new WaitForSeconds(cooldown);
        if (player != null)
        {
            GameObject weapon = Instantiate(projectile, transform.position, Quaternion.identity);
            Vector2 myPos = transform.position;
            Vector2 targetPos = player.transform.position;
            Vector2 direction = (targetPos - myPos).normalized;
            weapon.GetComponent<Rigidbody2D>().velocity = direction * projectileForce;
            weapon.GetComponent<EnemyProjectile>().damage = Random.Range(minDamage, maxDamage);
            StartCoroutine(ShootPlayer());
        }
    }
}
