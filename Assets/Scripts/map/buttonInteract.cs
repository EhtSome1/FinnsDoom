using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonInteract : MonoBehaviour
{
    public bool A_Button;
    public bool B_Button;
    public bool C_Button;

    public GameObject door;
    buttoncheck allButtons;
    public Animator animator;

    void Start()
    {
        allButtons = door.gameObject.GetComponent<buttoncheck>();
    }
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.F))
        {
            if (A_Button)
            {
                animator.SetBool("buttonpress", true);
                allButtons.A_Button = true;
            }
            else if (B_Button)
            {
                animator.SetBool("buttonpress", true);
                allButtons.B_Button = true;
            }
            else if (C_Button)
            {
                animator.SetBool("buttonpress", true);
                allButtons.C_Button = true;
            }
        }
    }
}
