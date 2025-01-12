using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawenr : MonoBehaviour
{
    public GameObject enemyPrefab;

    public float spawnRate = 2f;
    public float minXAxisspawnValue = -8f;
    public float maxXAxisspawnValue = 8f;

    public float yAxisSpawnValue = 3.5f;

    private float timeSinceLastAction = 0f;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceLastAction += Time.deltaTime;

        if (timeSinceLastAction >= spawnRate)
        {
            SpawnEnemy();
        }
    }

    void SpawnEnemy()
    {
        float xPosition = Random.Range(minXAxisspawnValue, maxXAxisspawnValue);
        Vector2 spawnPosition = new Vector2(xPosition, yAxisSpawnValue);
        Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);

        timeSinceLastAction = 0f;
    }




}

