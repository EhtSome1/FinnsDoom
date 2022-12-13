using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupSaltgun : MonoBehaviour
{
    GameObject player;

    public switchWeapon Switch;
    public Animations animations;

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                animations.currentWeapon = "saltgun";

                Destroy(gameObject);

                Debug.Log("picked up saltgun");

                Switch.hasSaltgun = true;

                Switch.saltGun.SetActive(true);
            }
        }
    }
    void Start()
    {
        player = GameObject.Find("Player");
        Switch = player.gameObject.GetComponent<switchWeapon>();
        animations = player.gameObject.GetComponent<Animations>();
    }
}
