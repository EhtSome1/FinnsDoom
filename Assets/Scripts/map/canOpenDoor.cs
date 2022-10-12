using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class canOpenDoor : MonoBehaviour
{
    public Animator dooranim;
    public Object sceneToLoad;
    public bool hasKey;

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (hasKey && Input.GetKeyDown(KeyCode.F))
            {
                SceneManager.LoadScene(sceneToLoad.name);
                dooranim.SetBool("doorOpen", true);
                Debug.Log("Door opened");
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
