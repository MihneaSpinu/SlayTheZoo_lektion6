using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    
    public GameObject enemyPrefab;
    public bool isSpawning = true;
    
    public float enemyInterval = 1f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnEnemy(enemyInterval, enemyPrefab));
    }

    private IEnumerator spawnEnemy(float interval, GameObject enemy)
    {
        if (!isSpawning) yield break;
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-6f, 6), 1.6f,Random.Range(-6f, 6)), Quaternion.identity);
        StartCoroutine(spawnEnemy(interval, enemy));
    }
}