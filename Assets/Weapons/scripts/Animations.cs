using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animations : MonoBehaviour
{
    public bool canReload = true;
    public bool hasShot = false;

    public GameObject reloadHandle;

    public ParticleSystem saltParticle;
    public ParticleSystem pelletParticle;

    public Animator saltgunReloadHandleAnimator;
    public Animator saltgunAnimator;

    public Animator doubleBarrelAnimator;

    public string currentWeapon;

    public int saltgunAmmo = 30;
    public int doubleBarrelAmmo = 30;

    public switchWeapon Switch;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        switch (currentWeapon)
        {
            case "saltgun":
                if (Input.GetKeyDown(KeyCode.Mouse0) && canReload && saltgunAmmo > 0)
                {
                    saltParticle.Play();

                    Invoke("reload", 0.07f);
                    Invoke("canShoot", 1.7f);
                    Invoke("canChange", 1.7f);

                    saltgunAmmo--;
                }
                break;
            case "doubleBarrel":
                if (Input.GetKeyDown(KeyCode.Mouse0) && canReload && doubleBarrelAmmo > 0 && hasShot == false)
                {
                    pelletParticle.Play();

                    doubleBarrelAmmo--;

                    hasShot = true;

                    canReload = false;
                    Invoke("canShoot2", 0.06f);
                }
                if (Input.GetKeyDown(KeyCode.Mouse0) && hasShot && canReload && doubleBarrelAmmo > 0)
                {
                    pelletParticle.Play();

                    Invoke("reload", 0.07f);
                    Invoke("canShoot", 3.4f);
                    Invoke("canChange", 3.4f);

                    doubleBarrelAmmo--;
                }

                break;
        }
    }

    void reload()
    {
        Switch.canShangeWeapon = false; 

        canReload = false;
        Debug.Log("canReload = false");

        if (currentWeapon == "saltgun")
        {
            saltgunAnimator.SetBool("reload", true);

            saltgunReloadHandleAnimator.SetBool("reload", true);
            Invoke("setFalse", 1.1f);
        }
        if(currentWeapon == "doubleBarrel")
        {
            doubleBarrelAnimator.SetBool("reload", true);
            Invoke("setFalse", 3.4f);
        }

    }

    void setFalse()
    {
        if (currentWeapon == "saltgun")
        {
            saltgunAnimator.SetBool("reload", false);

            saltgunReloadHandleAnimator.SetBool("reload", false);
        }
        if (currentWeapon == "doubleBarrel")
        {
            doubleBarrelAnimator.SetBool("reload", false);
        }
    }
    void canShoot()
    {
        Debug.Log("canRealode = true");
        canReload = true;

        hasShot = false;
    }

    void canShoot2()
    {
        canReload = true;
    }

    void canChange()
    {
        Switch.canShangeWeapon = true;
    }
}
