using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pickUpBucket : MonoBehaviour
{
    public bool inArea = false;
    GameObject player;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            Debug.Log("player enter");
            inArea = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if(other.gameObject.name == "Player")
        {
            Debug.Log("player exit");
            inArea = false;
        }
    }

    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (inArea && Input.GetKeyDown(KeyCode.F))
        {
            victory();
        }
    }

    void victory()
    {
        Destroy(player);

        SceneManager.LoadScene(7);
    }
}
