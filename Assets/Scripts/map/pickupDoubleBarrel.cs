using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupDoubleBarrel : MonoBehaviour
{
    public switchWeapon Switch;
    public Animations animations;

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

                Switch.doubleBarrel.SetActive(true);
            }
        }
    }
}
