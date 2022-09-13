using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    private float startTime;
    public float timer = 0;


    void Start()
    {
        DontDestroyOnLoad(gameObject);

        startTime = Time.time;    
    }

    void Update()
    {
        float t = Time.time - startTime;

        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f2");

        timerText.text = minutes + ":" + seconds;

        if (timer > 2)
        {
            SceneManager.LoadScene("Scene2");
        }
    }
}
