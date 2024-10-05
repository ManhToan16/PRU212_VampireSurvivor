using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyToSpawn;
    public float timeToSpawn;
    private float spawnCounter;
    public Transform minPoint, maxPoint;
    private Transform target;
    private float despawnDistance;
    private List<GameObject> spawnedEnemies = new List<GameObject>();

    void Start()
    {
        spawnCounter = timeToSpawn;
        target = PlayerHealthController.instance.transform;
    }

    void Update()
    {
        spawnCounter -= Time.deltaTime;
        if (spawnCounter <= 0)
        {
            spawnCounter = timeToSpawn;
            GameObject newEnemy = Instantiate(enemyToSpawn, SelectSpawnPoint(), transform.rotation);
            spawnedEnemies.Add(newEnemy);
        }

        transform.position = target.position;

    }


    public Vector3 SelectSpawnPoint()
    {
        Vector3 screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.nearClipPlane));

        Vector3 spawnPoint = Vector3.zero;
        bool spawnVerticalEdge = Random.Range(0f, 1f) > 0.5f;

        if (spawnVerticalEdge)
        {
            spawnPoint.x = Random.Range(minPoint.position.x, maxPoint.position.x);
            spawnPoint.y = Random.Range(0f, 1f) > 0.5f ? screenBounds.y + 2f : -screenBounds.y - 2f;
        }
        else
        {
            spawnPoint.x = Random.Range(0f, 1f) > 0.5f ? screenBounds.x + 2f : -screenBounds.x - 2f;
            spawnPoint.y = Random.Range(minPoint.position.y, maxPoint.position.y);
        }

        return spawnPoint;
    }

}
