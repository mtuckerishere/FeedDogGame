using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnX = 20.0f;
    private float spawnZ = 20.0f;
    private float initialSpawn = 2.0f;
    private float intervalSpawn = 1.5f;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", initialSpawn, intervalSpawn);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPoint = new Vector3(Random.Range(-spawnX, spawnX), 0, spawnZ);
        Instantiate(animalPrefabs[animalIndex], spawnPoint, animalPrefabs[animalIndex].transform.rotation);
    }
}
