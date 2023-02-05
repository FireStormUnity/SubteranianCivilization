using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CivilizationHP : MonoBehaviour
{
    public float health = 100f;
    public bool IsDead;
    private GameObject _myGameObject;

    private void Start()
    {
        _myGameObject = gameObject;
    }

    public void TakeDamage(float damage)
    {
        health -= damage;

        if (health <= 0f)
        {
            Die();
        }
    }

    private void Die()
    {
        IsDead = true;
        _myGameObject.GetComponent<HPSys>().Die();
        Destroy(gameObject);
    }

}

