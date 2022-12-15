using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class worldswitch2 : MonoBehaviour
{
        bool yes;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") /*&& this.CompareTag("WorldSwitch")*/)
        {
            yes = true;
        }
    }

    void Update()
    {

        if (yes)
        {
            SceneManager.LoadScene("The_Final_Map");

        }
    }
}



