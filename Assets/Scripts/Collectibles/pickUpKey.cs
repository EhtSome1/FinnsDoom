using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUpKey : MonoBehaviour
{
    public canOpenDoor Door;

    public GameObject avain;

    void OnTriggerStay(Collider other)
    {
        Debug.Log(other.gameObject.tag);

        if (other.gameObject.tag == "Player")
        {
            if (Input.GetKey(KeyCode.E))
            {
                Debug.Log("Picked up the key");

                Destroy(avain);

                Door.hasKey = true;
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
