using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupSaltgun : MonoBehaviour
{
    public switchWeapon Switch;

     void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                Destroy(gameObject);

                Debug.Log("picked up saltgun");

                Switch.hasSaltgun = true;

                Switch.saltGun.SetActive(true);
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
