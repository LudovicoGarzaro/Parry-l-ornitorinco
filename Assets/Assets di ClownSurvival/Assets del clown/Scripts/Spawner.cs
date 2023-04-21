using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject prefabToSpawn;
    public float spawnTime = 2;
    public float spawnRange = 10;

    float spawnTimer = 0;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer += Time.deltaTime;

        if(spawnTimer >= spawnTime)
        {
            Instantiate(prefabToSpawn, Random.insideUnitCircle * spawnRange, Quaternion.identity, transform);
            spawnTimer = 0;
        }
    }
}
