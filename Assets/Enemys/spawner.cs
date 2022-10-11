using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    /*int maxHytty = 15;
    int currentHytty = 0;


    public GameObject hytty;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHytty < 15)
        {
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-0.02167f, 0.0224f), Random.Range(-0.02154f, 0.0167f), 0.00855f);
            Instantiate(hytty, randomSpawnPosition, Quaternion.identity);

            currentHytty++;
        }
    }*/
    public int maxHytty = 15;
    public int currentHytty = 0;

    public GameObject spawnedPrefab;
    public BoxCollider spawnArea;
    Vector2 maxSpawnPos;

    float lastSpawnTimeS = -1;
    public float spawnDelayS = 5;

    // Use this for initialization
    void Start()
    {
        spawnArea = GetComponent<BoxCollider>();
        spawnArea.enabled = false;
        maxSpawnPos = new Vector2(spawnArea.size.x / 2, spawnArea.size.y / 2);
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHytty != maxHytty)
        {
            if (lastSpawnTimeS < 0)
            {
                lastSpawnTimeS = Time.time;
                GameObject spawned = Instantiate(spawnedPrefab, Vector3.zero, Quaternion.identity) as GameObject;
                spawned.transform.parent = transform;
                Vector3 pos = new Vector3(Random.Range(-maxSpawnPos.x, maxSpawnPos.x), Random.Range(-maxSpawnPos.y, maxSpawnPos.y), 0);
                spawned.transform.localPosition = pos;
                currentHytty++;
            }
            else if (lastSpawnTimeS >= 0 && Time.time - lastSpawnTimeS > spawnDelayS)
            {
                lastSpawnTimeS = -1;
            }
        }

    }
}