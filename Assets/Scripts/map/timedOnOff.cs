using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timedOnOff : MonoBehaviour
{
    public ParticleSystem particles;

    public float time = 2f;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("on", time);
    }
     
    void on()
    {
        particles.Play();
        Invoke("off", time);
    }
    void off()
    {
        particles.Stop();
        Invoke("on", time);
    }
}
