using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    private float startTime;
    //bool switchedScene = false;
    public float timer = 0;
    bool switchedScene = false;


    void Start()
    {
        DontDestroyOnLoad(gameObject);

        startTime = Time.time;
    }

    void Update()
    {
        float t = Time.time;

        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f2");

        timerText.text = minutes + ":" + seconds;
        TimingManager.myTimer += Time.deltaTime;
       
        Debug.Log(TimingManager.myTimer);
    }
}
