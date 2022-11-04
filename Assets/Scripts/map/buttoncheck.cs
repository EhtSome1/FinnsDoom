using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttoncheck : MonoBehaviour
{
    public Animator animator;
    public bool A_Button = false;
    public bool B_Button = false;
    public bool C_Button = false;
    public bool doorOpen = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     if (A_Button && B_Button && C_Button && !doorOpen)
        {
            animator.SetBool("doorOpen", true);
            doorOpen = true;
        }
    }
}
