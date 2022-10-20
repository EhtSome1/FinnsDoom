using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchSceneByKills : MonoBehaviour
{
    public int KillsToGet;

    deathcounter deaths;

    // Start is called before the first frame update
    void Start()
    {
        deaths = gameObject.GetComponent<deathcounter>();
    }

    // Update is called once per frame
    void Update()
    {
        if (KillsToGet >= deaths.deadEnemys)
        {

        }
    }
}
