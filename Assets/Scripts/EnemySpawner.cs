using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemyToSpawn;
    public float timeToSpawn;
    private float spawnCounter;
    void Start()
    {
        spawnCounter=timeToSpawn;
    }

    // Update is called once per frame
    void Update()
    {
        spawnCounter-=Time.deltaTime;
        if (spawnCounter <= 0) {
            spawnCounter = timeToSpawn;
            Instantiate(enemyToSpawn,transform.position,transform.rotation);
        }
    }
}
