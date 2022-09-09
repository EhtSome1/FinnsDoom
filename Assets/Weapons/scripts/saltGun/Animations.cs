using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animations : MonoBehaviour
{
    public bool canReload = true;

    public GameObject reloadHandle;

    public ParticleSystem saltParticle;

    public Animator reloadHandleAnimator;
    public Animator animator;


    public int ammo = 30;

    // Start is called before the first frame update
    void Start()
    {
        reloadHandleAnimator = reloadHandle.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && canReload && ammo > 0)
        {
            saltParticle.Play();

            Invoke("reload", 0.07f);

            ammo--;
        }
    }

    void reload()
    {
        canReload = false;

        animator.SetBool("reload", true);

        reloadHandleAnimator.SetBool("reload", true);

        Invoke("setFalse", 1.1f);
    }

    void setFalse()
    {
        animator.SetBool("reload", false);

        reloadHandleAnimator.SetBool("reload", false);

        canReload = true;
    }
}
