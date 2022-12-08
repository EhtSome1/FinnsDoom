using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throw : MonoBehaviour
{
    public Transform target;
    public float attackSpeed;
    float timer;

    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {
            Vector3 dir = target.position - transform.position;
            float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;

            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                timer = attackSpeed;
                Instantiate(projectilePrefab, transform.position, Quaternion.LookRotation(dir, Vector3.up));
            }
        }
    }
}