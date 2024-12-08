using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject asteroidPrefab;
    public GameObject enemyPrefab;
    public Transform playerCamera;
    public float spawnInterval = 2f;
    public float safeDistance = 10f;
    public float farDistance = 10f;

    private void Start()
    {
        InvokeRepeating(nameof(SpawnAsteroid), spawnInterval, spawnInterval);
        InvokeRepeating(nameof(SpawnEnemy), spawnInterval, spawnInterval);
        
    }
    
    void SpawnAsteroid()
    {
        Vector3 spawnPosition = RandomPosn();
        Instantiate(asteroidPrefab, spawnPosition, Quaternion.identity);
        //Debug.Log("Spawn Asteroid");
    }

    void SpawnEnemy()
    {
        Vector3 spawnPosition = RandomPosn();
        Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
        //Debug.Log("Spawn Enemy");
    }

    Vector3 RandomPosn()
    {
        Vector3 posn;

        do
        {
            posn = new Vector3(Random.Range(-50, 50), Random.Range(-50, 50), Random.Range(-50, 50));
        }
        while (Vector3.Distance(posn, playerCamera.position) < safeDistance && Vector3.Distance(posn, playerCamera.position) > farDistance);

        return posn;
    }
}
