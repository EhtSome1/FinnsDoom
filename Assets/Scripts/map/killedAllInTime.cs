using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class killedAllInTime : MonoBehaviour
{
    public GameObject Bucket;
    public GameObject Camera;
    GameObject player;
    GameObject Canva;

    bool can = true;

    public ParticleSystem particles;

    public deathcounter deathCounter;

    public float targetTime = 300.0f;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        Canva = GameObject.Find("Canva");
    }

    // Update is called once per frame
    void Update()
    {
        targetTime -= Time.deltaTime;

        if (targetTime <= 0.0f && can)
        {
            timerEnded();
            can = false;
        }
    }

    void timerEnded()
    {
        if (deathCounter.deadEnemys == deathCounter.needed_deaths)
        {

        }
        else if(deathCounter.deadEnemys != deathCounter.needed_deaths)
        {
            Destroy(player);
            Destroy(Canva);
            Camera.SetActive(true);

            Invoke("destroyBucket", 1f);
        }
    }

    void destroyBucket()
    {
        Destroy(Bucket);
        particles.Play();

        Invoke("defeatScreen", 1f);
    }
    void defeatScreen()
    {
        Cursor.lockState = CursorLockMode.Confined;

        SceneManager.LoadScene(6);
    }
}
