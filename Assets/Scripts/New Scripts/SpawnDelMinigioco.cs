using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDelMinigioco : MonoBehaviour
{

    public GameObject enemyOrkey;
    
    public float spawnTime = 1f;
    private float defaultST;
    private bool timeOut;

    void Awake()
    {
        enemyOrkey.SetActive(false);

        defaultST = spawnTime;

        timeOut = false;
    }

    
    void Update()
    {

        spawnTime -= Time.deltaTime;

        if (spawnTime <= 0f)
        {
            enemyOrkey.SetActive(true);

            timeOut = true;

        }

        if(timeOut == true)
        {
            spawnTime = 1f;
        }

        
    }
}
