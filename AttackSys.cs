using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackSys : MonoBehaviour
{
    public float attackRadius = 5f;
    public int damage = 10;
    public float attackCooldown = 1f;
    private float lastAttackTime;
    public Animator animat;

    void Update()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject enemy in enemies)
        {
            float distance = Vector3.Distance(transform.position, enemy.transform.position);
            if (distance <= attackRadius)
            {
                if (Time.time - lastAttackTime >= attackCooldown)
                {
                    lastAttackTime = Time.time;
                    animat.SetTrigger("Attack");
                    enemy.GetComponent<Enemy>().TakeDamage(damage);
                }
            }
            else
            {
                
            }
        }
    }
}
