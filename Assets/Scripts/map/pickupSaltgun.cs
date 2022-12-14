using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupSaltgun : MonoBehaviour
{
    GameObject player;

    public switchWeapon Switch;
    public Animations animations;

    bool inArea = false;

    private void OnTriggerEnter(Collider other)
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
    void Start()
    {
        player = GameObject.Find("Player");
        Switch = player.gameObject.GetComponent<switchWeapon>();
        animations = player.gameObject.GetComponent<Animations>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && inArea)
        {
            animations.currentWeapon = "saltgun";

            Destroy(gameObject);

            Debug.Log("picked up saltgun");

            Switch.hasSaltgun = true;

            Switch.saltGun.SetActive(true);
        }
    }
}
