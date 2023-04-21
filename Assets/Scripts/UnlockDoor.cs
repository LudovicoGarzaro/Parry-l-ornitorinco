using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockDoor : MonoBehaviour
{

    GameObject[] enemies;
    private int numberOfenemies;

    private void Update()
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy");

        numberOfenemies = enemies.Length;

        if(numberOfenemies == 0)
        {
            Destroy(gameObject);
        }
    }





}

