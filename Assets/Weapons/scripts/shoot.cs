using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public Animations animations;

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
                    if (animations.currentWeapon == "saltgun")
                    {
                        hyttyHealth enemyHP;
                        enemyHP = other.gameObject.GetComponent<hyttyHealth>();

                        enemyHP.health--;
                    }
                    break;

                case "murkku":
                    Debug.Log("Hit murkku");
                    if (animations.currentWeapon == "doubleBarrel")
                    {
                        enemyHealth enemyHP;
                        enemyHP = other.gameObject.GetComponent<enemyHealth>();

                        enemyHP.health--;
                    }
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
