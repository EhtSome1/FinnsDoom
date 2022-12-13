using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class getTimerTime : MonoBehaviour
{
    Timer timer;
    GameObject TheTimer;
    GameObject PlayerCanvas;

    public TextMeshProUGUI timerText;
    // Start is called before the first frame update
    void Start()
    {
        PlayerCanvas = GameObject.Find("Canvas");
        TheTimer = GameObject.Find("Timer");
        timer = TheTimer.gameObject.GetComponent<Timer>();

        timerText.text = timer.timerText.text;

        Destroy(PlayerCanvas);
    }
}
