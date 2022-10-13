using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hyttyHealth : MonoBehaviour
{
    public GameObject hytty;

    public int health = 40;

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            Destroy(hytty);
        }
    }
}
