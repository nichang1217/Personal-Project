using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] greekPrefabs; 
    public GameObject[] powerupPrefabs;
    public GameObject projectilePrefab;
    private float greekSpawnRangeX = 30;
    private float greekSpawnPosZ = 16.5f;
    private float StartDelay = 3;
    private float greekSpawnInterval = 7;
    private float powerupSpawnRangeX = 30;
    private float powerupSpawnRangeZ1 = -3;
    private float powerupSpawnRangeZ2 = 13;
    private float powerupSpawnInterval = 30;
    
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomGreek", StartDelay, greekSpawnInterval);
        InvokeRepeating("SpawnRandomPowerup", StartDelay * 2, powerupSpawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomGreek()
    {
        int greekIndex = Random.Range(0, greekPrefabs.Length);
            Vector3 greekSpawnPos = new Vector3(Random.Range(-greekSpawnRangeX, greekSpawnRangeX), 1.05f, greekSpawnPosZ);

            Instantiate(greekPrefabs[greekIndex], greekSpawnPos, greekPrefabs[0].transform.rotation);
    }
    void SpawnRandomPowerup()
    {
        int powerupIndex = Random.Range(0, powerupPrefabs.Length);
            Vector3 powerupSpawnPos = new Vector3(Random.Range(-powerupSpawnRangeX, powerupSpawnRangeX), 1.05f, Random.Range(powerupSpawnRangeZ1, powerupSpawnRangeZ2));

            Instantiate(powerupPrefabs[powerupIndex], powerupSpawnPos, powerupPrefabs[0].transform.rotation);
    }
}

