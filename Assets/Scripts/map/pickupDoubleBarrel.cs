using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupDoubleBarrel : MonoBehaviour
{
    GameObject player;

    switchWeapon Switch;
    Animations animations;

    void Start()
    {
        player = GameObject.Find("Player");

        Switch = player.gameObject.GetComponent<switchWeapon>();
        animations = player.gameObject.GetComponent<Animations>();
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
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
