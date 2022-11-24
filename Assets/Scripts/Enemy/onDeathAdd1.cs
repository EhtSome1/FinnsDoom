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

        hp = gameObject.GetComponent<enemyHealth>();
    }

    void Update()
    {
        if (hp.health <= 0)
        {
            DeathCounter.deadEnemys++;
        }
    }
}
