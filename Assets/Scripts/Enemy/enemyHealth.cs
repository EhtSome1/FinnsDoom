using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHealth : MonoBehaviour
{
    public GameObject itself;

    public int health = 100;

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            Destroy(itself);

            Debug.Log("Killed enemy");
        }
    }
}
