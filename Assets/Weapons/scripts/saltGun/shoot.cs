using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public ParticleSystem particles;

    void OnParticleCollision(GameObject other)
    {
        Debug.Log("Hit something!");

        particles.Stop();

        if (other.gameObject.layer == 9)
        {
            Debug.Log("Hit enemy!");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
