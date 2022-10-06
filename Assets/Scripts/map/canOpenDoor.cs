using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canOpenDoor : MonoBehaviour
{
    public bool hasKey;

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (hasKey && Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("Door opened");
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
