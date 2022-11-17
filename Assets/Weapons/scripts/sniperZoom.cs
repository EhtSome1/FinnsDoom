using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sniperZoom : MonoBehaviour
{
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            animator.SetBool("zoom", true);
        }
        if (Input.GetKeyUp(KeyCode.Mouse1))
        {
            animator.SetBool("zoom", false);
        }
    }
}
