using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer666 : MonoBehaviour
{
    GameObject Tuhottava;
    void Start()
    {
        Tuhottava = GameObject.Find("DontDestroyOnLoad");
        Destroy(Tuhottava);
        Destroy(FindObjectOfType<dontDestroyOnLoad>());

    }

}
