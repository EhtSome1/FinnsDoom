using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathcounter : MonoBehaviour
{
    public int deadEnemys = 0;
    public int needed_deaths = 8;
    public GameObject objecti;

    public bool turnOn = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (deadEnemys == needed_deaths && turnOn)
        {
            objecti.SetActive(true);
        }
        if (deadEnemys == needed_deaths && !turnOn)
        {
            objecti.SetActive(false);
        }
    }
}
