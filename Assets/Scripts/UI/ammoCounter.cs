using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ammoCounter : MonoBehaviour
{
    public TMP_Text magAmmo;
    public TMP_Text AllAmmo;
    
    GameObject player;
    public GameObject sniper;

    sniperShoot snipershoot;
    Animations animations;



    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        animations = player.gameObject.GetComponent<Animations>();
        snipershoot = sniper.gameObject.GetComponent<sniperShoot>();
    }

    // Update is called once per frame
    void Update()
    {
        if (animations.currentWeapon == "saltgun")
        {
            magAmmo.text = Convert.ToString(animations.saltgunAmmo);
            AllAmmo.text = null;
        }
        if (animations.currentWeapon == "doubleBarrel")
        {
            magAmmo.text = Convert.ToString(animations.doubleBarrelMagAmmo);
            AllAmmo.text = Convert.ToString(animations.doubleBarrelAmmo);
        }
        if (animations.currentWeapon == "sniper")
        {
            magAmmo.text = Convert.ToString(snipershoot.magAmmo);
            AllAmmo.text = Convert.ToString(snipershoot.ammo);
        }
    }
}
