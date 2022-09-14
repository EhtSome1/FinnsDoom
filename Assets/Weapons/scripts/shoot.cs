using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public ParticleSystem particles;

    void OnParticleCollision(GameObject other)
    {
        Debug.Log("Hit something!");

        if (other.gameObject.layer == 6)
        {
            Debug.Log("Hit something");
            Debug.Log("Hit enemy!");
            switch (other.gameObject.tag)
            {
                case "hytty":
                    Debug.Log("Hit hytty!");

                    hyttyHealth enemyHP;
                    enemyHP = other.gameObject.GetComponent<hyttyHealth>();

                    enemyHP.health--;
                    break;
            }

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
