using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waves : MonoBehaviour
{
    public GameObject h�kki;
    public GameObject Enemys;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            h�kki.gameObject.GetComponent<killedAllInTime>().enabled = true;

            Enemys.SetActive(true);
        }
    }
}
