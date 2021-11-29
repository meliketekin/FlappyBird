using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnSpawner : MonoBehaviour
{
    public GameObject columnPrefab;
    public float minY, maxY;
    float timer;
    public float maxTime;
    void Start()
    {
        SpawnColumn(); 
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= maxTime) // maxTime = 1.5
        {
            SpawnColumn();
            timer = 0;
        }
    }
    void SpawnColumn()
    {
        float randomYposition = Random.Range(minY, maxY);
        GameObject newColumn = Instantiate(columnPrefab);
        newColumn.transform.position = new Vector2(transform.position.x, randomYposition);
    }
}
