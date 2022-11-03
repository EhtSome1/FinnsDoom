using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour
{

    void Start()
    {

    }

    void Update()
    {

    }

    public Playermovement playermovement;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && this.CompareTag("Jump_Pad"))
        {
            Debug.Log("toimii");
            playermovement.jumpHeight = 5f;

        }       
       }

    private void OnTriggerExit(Collider other)5z++§1234567890´Qerpoå
        ÄSDFGÖÄ'
        z< 
    {
        playermovement.jumpHeight = 1f;

    }
}

    
    




