using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waves : MonoBehaviour
{
    GameObject canvas;
    public GameObject häkki;
    public GameObject Enemys;

    objectiveManager objectiveMan;

    void Start()
    {
        canvas = GameObject.Find("Canvas");
        objectiveMan = canvas.gameObject.GetComponent<objectiveManager>();
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            häkki.gameObject.GetComponent<killedAllInTime>().enabled = true;

            Enemys.SetActive(true);
            objectiveMan.inBattle = true;
        }
    }
}
