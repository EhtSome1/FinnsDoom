using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onDeathAdd1 : MonoBehaviour
{
    GameObject Deathcounter;
    deathcounter DeathCounter;
    public enemyHealth hp;

    void Start()
    {
        Deathcounter = GameObject.Find("deathCounter");
        DeathCounter = Deathcounter.GetComponent<deathcounter>();
    }

    void Update()
    {
        Debug.Log("?");

        if (hp.health <= 0)
        {
            Debug.Log("hp = 0");
            DeathCounter.deadEnemys++;
        }
    }
}
