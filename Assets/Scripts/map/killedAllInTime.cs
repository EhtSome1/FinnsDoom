using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killedAllInTime : MonoBehaviour
{
    public deathcounter deathCounter;

    public float targetTime = 300.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        targetTime -= Time.deltaTime;

        if (targetTime <= 0.0f)
        {
            timerEnded();
        }
    }

    void timerEnded()
    {
        if (deathCounter.deadEnemys == deathCounter.needed_deaths)
        {

        }
        else if(deathCounter.deadEnemys != deathCounter.needed_deaths)
        {

        }
    }
}
