﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehaviour : MonoBehaviour
{

    [SerializeField]
    [Range(10, 100)]
    int projectileSpeed;
    [SerializeField]
    int damage;

    // Use this for initialization
    void Start()
    {
        //GetComponent<Rigidbody2D>().AddForce(new Vector2(projectileSpeed*transform.rotation.x, projectileSpeed*transform.rotation.y));
        GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(projectileSpeed, 0));
        Destroy(gameObject, 2);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag.Equals("Enemy"))
        {
            EnemyBehavior enemyBehavior = coll.gameObject.GetComponent<EnemyBehavior>();
            enemyBehavior.onDamage(damage);
        }
        if (!coll.gameObject.tag.Equals("Projectile") && !coll.gameObject.tag.Equals("Player"))
            Destroy(gameObject);
    }
}
