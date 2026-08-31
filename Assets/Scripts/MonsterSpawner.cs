using System.Collections.Generic;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private float speed = 1f;
    private float lastTimeMeasure;

    List<GameObject> spawnPositions;

    [SerializeField]
    List<GameObject> enemiesPrefabs;

    void SpawnEnemy()
    {
        int randomEnemy = Random.Range(0, enemiesPrefabs.Count);
        int randomPos = Random.Range(0, spawnPositions.Count);

        GameObject enemy = Instantiate(enemiesPrefabs[randomEnemy], spawnPositions[randomPos].transform.position, Quaternion.identity);
        enemy.GetComponent<EnemyScript>().Initialize(speed);
    }

    void Awake()
    {
        spawnPositions = new List<GameObject>();
        foreach (Transform child in transform)
        {
            spawnPositions.Add(child.gameObject);
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 0, 1);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - lastTimeMeasure >= 5f)
        {
            speed = speed * 1.1f;
            lastTimeMeasure = Time.time;
        }
    }
}
