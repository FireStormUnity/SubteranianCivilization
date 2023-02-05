using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public float attackRadius = 2f;
    public float damage = 10f;
    public float speed = 3f;
    public float attackCoolDown = 1f;
    public int HP;

    private Transform nearestSoldier;
    private float lastAttackTime;

    void Update()
    {
        FindNearestSoldier();
        if (nearestSoldier)
        {
            float distance = Vector2.Distance(transform.position, nearestSoldier.position);
            if (distance <= attackRadius)
            {
                if (Time.time - lastAttackTime >= attackCoolDown)
                {
                    Attack();
                    lastAttackTime = Time.time;
                }
            }
            else
            {
                MoveTowardsSoldier();
            }
        }
    }

    void FindNearestSoldier()
    {
        GameObject[] soldiers = GameObject.FindGameObjectsWithTag("Soldier");
        float minDistance = float.MaxValue;
        foreach (GameObject soldier in soldiers)
        {
            float distance = Vector2.Distance(transform.position, soldier.transform.position);
            if (distance < minDistance)
            {
                minDistance = distance;
                nearestSoldier = soldier.transform;
            }
        }
    }

    void MoveTowardsSoldier()
    {
        Vector2 direction = (nearestSoldier.position - transform.position).normalized;
        transform.position = transform.position + (Vector3)direction * speed * Time.deltaTime;

        if (direction.x > 0)
        {
            transform.rotation = Quaternion.Euler(0, 110, 0);
        }
        else if (direction.x < 0)
        {
            transform.rotation = Quaternion.Euler(0, -110, 0);
        }
    }

    void Attack()
    {
        nearestSoldier.GetComponent<CivilizationHP>().TakeDamage(damage);
    }
    public void TakeDamage(int damage)
    {
        HP -= damage;
        if(HP <=0)
        {
            Die();
        }
    }
    public void Die()
    {       
        Destroy(gameObject);
        GameData.Tooth += 4;
    }

}


