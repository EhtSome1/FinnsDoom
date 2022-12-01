using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupSaltgun : MonoBehaviour
{
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
}
