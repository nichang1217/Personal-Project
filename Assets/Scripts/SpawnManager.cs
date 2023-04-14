using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] greekPrefabs; 
    public GameObject[] powerupPrefabs;
    private float greekSpawnRangeX = 30;
    private float greekSpawnPosZ = 16.5f;
    private float StartDelay = 3;
    private float greekSpawnInterval = 10;
    
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomGreek", StartDelay, greekSpawnInterval);
        int i = Random.Range(0, powerupPrefabs.Length);
        Instantiate(powerupPrefabs[i], GenerateSpawnPosition(), powerupPrefabs[i].transform.rotation);
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

    public Vector3 GenerateSpawnPosition()
    {
        float powerupSpawnRangeX = 30;
        float powerupSpawnRangeZ = Random.Range(-3, 13);

        Vector3 randomPos = new Vector3(powerupSpawnRangeX, 0.9f, powerupSpawnRangeZ);

        return randomPos;
    }
}

