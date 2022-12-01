using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUpSniper : MonoBehaviour
{
    GameObject player;

    switchWeapon weaponSwitch;
    Animations animations;

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "Player" && Input.GetKey(KeyCode.F))
        {
            weaponSwitch.saltGun.SetActive(false);
            weaponSwitch.doubleBarrel.SetActive(false);
            weaponSwitch.sniper.SetActive(true);
            weaponSwitch.hasSniper = true;

            animations.currentWeapon = "sniper";

            Destroy(gameObject);
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        weaponSwitch = player.gameObject.GetComponent<switchWeapon>();
        animations = player.gameObject.GetComponent<Animations>();
    }
}
