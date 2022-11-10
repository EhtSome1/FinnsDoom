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
                dooranim.SetBool("doorOpen", true);
                Debug.Log("Door opened");
                SceneManager.LoadScene(3);
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
