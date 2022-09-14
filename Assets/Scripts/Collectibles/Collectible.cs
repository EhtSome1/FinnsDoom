using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public GameObject player;
    PlayerHP playerhp;
    public static event Action OnCollected;
    void Update()
    {
        transform.Rotate(0f, 0.3f, 0f, Space.Self);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            OnCollected?.Invoke();
            Destroy(gameObject);
        }
    }
}
