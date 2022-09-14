using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchWeapon : MonoBehaviour
{
    public GameObject saltGun;
    public GameObject doubleBarrel;

    public Animations weaponAnimations;

    bool canShangeWeapon = true;

    // Start is called before the first frame update
    void Start()
    {
        weaponAnimations = weaponAnimations.GetComponent<Animations>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canShangeWeapon && weaponAnimations.currentWeapon == "saltgun" && Input.GetKey(KeyCode.E))
        {
            saltGun.SetActive(false);
            doubleBarrel.SetActive(true);

            weaponAnimations.currentWeapon = "doubleBarrel";

            canShangeWeapon = false;

            Invoke("EnableWeaponChange", 0.6f);

        }

        if (canShangeWeapon && weaponAnimations.currentWeapon == "doubleBarrel" && Input.GetKey(KeyCode.Q))
        {
            saltGun.SetActive(true);
            doubleBarrel.SetActive(false);

            weaponAnimations.currentWeapon = "saltgun";

            canShangeWeapon = false;

            Invoke("EnableWeaponChange", 0.6f);

        }
    }

    void EnableWeaponChange()
    {
        canShangeWeapon = true;
    }
}
