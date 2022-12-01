using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sniperShoot : MonoBehaviour
{
    public bool canShoot = true;
    public float ammo = 20;
    public float magAmmo = 5;
    public int damage = 40;

    public Animator animator;

    public GameObject sniper;

    // Start is called before the first frame update
    void Start()
    {
        animator.SetFloat("magAmmo", magAmmo);
        animator.SetFloat("ammo", ammo);
    }

    // Update is called once per frame
    void Update()
    {
        int layerMask = 1 << 6;
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, layerMask))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
        }
            // Bit shift the index of the layer (8) to get a bit mask
            

        // This would cast rays only against colliders in layer 8.
        // But instead we want to collide against everything except layer 8. The ~ operator does this, it inverts a bitmask.

        
        // Does the ray intersect any objects excluding the player layer
        if (Input.GetKey(KeyCode.Mouse0) && canShoot && magAmmo > 0)
        {
            canShoot = false;
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, layerMask))
            {
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
                Debug.Log("Hit " + hit.transform.gameObject.tag);
                
                
                enemyHealth enemyHP;
                enemyHP = hit.transform.gameObject.GetComponent<enemyHealth>();

                enemyHP.health = enemyHP.health - damage;
            }
            else
            {
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white);
                Debug.Log("Did not Hit");
            }

            animator.SetBool("reload", true);
            Invoke("dontReload", 1.5f);

            magAmmo--;
            ammo--;

            animator.SetFloat("magAmmo", magAmmo);
            animator.SetFloat("ammo", ammo);

            Invoke("enableShoot", 1.5f);
        }
        if (magAmmo <= 0 && ammo > 0)
        {
            changeMag();
            Debug.Log("call changeMag");
        }


    }

    void changeMag()
    {
        canShoot = false;

        Invoke("putAmmoToMag", 5.4f);

        Invoke("enableShoot", 5.5f);

        Debug.Log("Mag changed");
    }

    void putAmmoToMag()
    {
        if (ammo <= 5)
        {
            magAmmo = ammo;
            animator.SetFloat("magAmmo", magAmmo);
        }
        else if (ammo > 5)
        {
            magAmmo = 5;
            animator.SetFloat("magAmmo", 5);
        }
    }

    void enableShoot()
    {
        canShoot = true;
    }

    void dontReload()
    {
        animator.SetBool("reload",false);
    }
}
