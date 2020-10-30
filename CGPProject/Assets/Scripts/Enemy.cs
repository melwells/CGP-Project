using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int enemyHealth;
    //DamageTaken determines brick's damage dependent on type of brick
    public void DamageTaken(int damage)
    {
        enemyHealth -= damage;
        if (enemyHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy (gameObject);
    }
}
