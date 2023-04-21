using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    [SerializeField] int Health, maxHealth = 3;

    void Start()
    {
        Health = maxHealth;
    }

    // Update is called once per frame
    public void TakeDamage(int damageAmmount)
    {
        Health -= damageAmmount;

        if(Health <= 0)
        {
            Destroy(gameObject);
        }
          
    }
}
