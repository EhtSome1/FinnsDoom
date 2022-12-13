using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public Animations animations;

    public ParticleSystem particles;

    void OnParticleCollision(GameObject other)
    {

        if (other.gameObject.layer == 6)
        {

            switch (other.gameObject.tag)
            {
                case "hytty":
                    if (animations.currentWeapon == "saltgun")
                    {
                        enemyHealth enemyHP;
                        enemyHP = other.gameObject.GetComponent<enemyHealth>();

                        enemyHP.health--;
                    }
                    break;

                case "murkku":
                    if (animations.currentWeapon == "doubleBarrel")
                    {
                        enemyHealth enemyHP;
                        enemyHP = other.gameObject.GetComponent<enemyHealth>();

                        enemyHP.health--;
                    }
                    break;
            }

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