using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUpBucket : MonoBehaviour
{
    public bool inArea = false;


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            Debug.Log("player enter");
            inArea = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if(other.gameObject.name == "Player")
        {
            Debug.Log("player exit");
            inArea = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (inArea && Input.GetKeyDown(KeyCode.F))
        {
            victory();
        }
    }

    void victory()
    {

    }
}
