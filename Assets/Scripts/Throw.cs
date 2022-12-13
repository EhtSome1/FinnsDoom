using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Throw : MonoBehaviour
{
    public PlayerHP playerhp;
    public Transform target;
    public float attackSpeed;
    float timer;
    public GameObject projectilePrefab;
    void Start()
    {
        target = GameObject.Find("Player").transform;
    }
    void Update()
    {
        if (target != null)
        {
            Vector3 dir = new Vector3(target.position.x, transform.position.y, target.transform.position.z) - transform.position;
            float angle = Mathf.Atan(dir.x) * Mathf.Rad2Deg;

            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                timer = attackSpeed;
                Instantiate(projectilePrefab, transform.position, Quaternion.LookRotation(dir, Vector3.up));
            }
        }
    }
}