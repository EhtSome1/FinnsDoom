using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toAnotherScene : MonoBehaviour
{
    bool joo = false;


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            joo = true;
        }

    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (joo)
        {
            SceneManager.LoadScene("the_fourth_map");
        }
    }
}
