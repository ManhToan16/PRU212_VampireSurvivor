using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemyToSpawn;
    public float timeToSpawn;
    private float spawnCounter;
    public Transform minPoint, maxPoint;
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
            //Instantiate(enemyToSpawn,transform.position,transform.rotation);
            Instantiate(enemyToSpawn, SelectSpawnPoint(),transform.rotation);
        }
    }
    public Vector3 SelectSpawnPoint()
    {
        Vector3 spawnPoint= Vector3.zero;
        bool spawnVerticalEdge = Random.Range(0f, 1f) > 0.5f;
        if (spawnVerticalEdge)
        {
            spawnPoint.y=Random.Range(minPoint.position.y, maxPoint.position.y);
            if (Random.Range(0f, 1f) > .5f)
            {
                spawnPoint.x = maxPoint.position.x;

            }
            else
            {
                spawnPoint.x=minPoint.position.x;   
            }
        }
        else
        {
            spawnPoint.x = Random.Range(minPoint.position.x, maxPoint.position.x);
            if (Random.Range(0f, 1f) > .5f)
            {
                spawnPoint.y = maxPoint.position.y;

            }
            else
            {
                spawnPoint.y = minPoint.position.y;
            }
        }
        return spawnPoint;
    }
}
