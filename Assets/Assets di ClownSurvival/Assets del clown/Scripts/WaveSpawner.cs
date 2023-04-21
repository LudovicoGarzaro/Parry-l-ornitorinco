using UnityEngine;
using TMPro;
using System.Collections;

public class WaveSpawner : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    public Transform[] spawnPoints;
    public float timeBetweenWaves = 5f;
    public float timeBetweenSpawn = 5f;

    private float countdown = 2f;
    private int waveIndex = 0; public TextMeshProUGUI waveDisplay;

    void Update()
    {
        if (countdown <= 0f)
        {
            StartCoroutine(SpawnWave());
            countdown = timeBetweenWaves;
        }
        countdown -= Time.deltaTime;
    }

    IEnumerator SpawnWave()
    {
        waveIndex++;
        waveDisplay.text = "Wave: " + waveIndex;
        for (int i = 0; i < waveIndex; i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(5f);
        }
    }

    void SpawnEnemy()
    {
        // Choose a random enemy prefab to spawn
        int enemyIndex = Random.Range(0, enemyPrefabs.Length);
        GameObject enemy = enemyPrefabs[enemyIndex];

        // Choose a random spawn point
        int spawnIndex = Random.Range(0, spawnPoints.Length);
        Transform spawnPoint = spawnPoints[spawnIndex];

        // Spawn the enemy
        GameObject spawnedEnemy = Instantiate(enemy, spawnPoint.position, Quaternion.identity);
    }
}