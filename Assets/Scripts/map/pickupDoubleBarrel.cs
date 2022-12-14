using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupDoubleBarrel : MonoBehaviour
{
    GameObject player;

    switchWeapon Switch;
    Animations animations;

    bool inArea = false;

    void Start()
    {
        player = GameObject.Find("Player");

        Switch = player.gameObject.GetComponent<switchWeapon>();
        animations = player.gameObject.GetComponent<Animations>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            inArea = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            inArea = false;
        }
    }

    void Update()
    {
        if(inArea)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                animations.currentWeapon = "doubleBarrel";

                Destroy(gameObject);

                Debug.Log("picked up Double barrel");

                Switch.hasShotgun = true;

                Switch.saltGun.SetActive(false);
                Switch.doubleBarrel.SetActive(true);
            }
        }
    }
}
