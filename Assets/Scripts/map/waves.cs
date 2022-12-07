using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waves : MonoBehaviour
{
    public GameObject Enemys;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Enemys.SetActive(true);
        }
    }
}
