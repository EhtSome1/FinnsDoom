using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    int maxHytty = 15;
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
    }
}
