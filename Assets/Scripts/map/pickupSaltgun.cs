using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupSaltgun : MonoBehaviour
{

     void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Destroy(gameObject);

                Debug.Log("picked up saltgun");
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
