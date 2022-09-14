using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public PlayerHP playerHP;
    
    public static event Action OnCollected;
    void Update()
    {
        transform.Rotate(0f, 0.3f, 0f, Space.Self);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && this.CompareTag("Health"))
        {
            OnCollected?.Invoke();
            if (playerHP.playerHP < 100)
            {
            playerHP.playerHP += 20;
            Destroy(gameObject);
            }
            if (playerHP.playerHP > 100)
            {
                playerHP.playerHP = 100;
            }         
        }

        if (other.CompareTag("Player") && this.CompareTag("Armor"))
        {
            OnCollected?.Invoke();
            if (playerHP.playerArmor < 50)
            {
                playerHP.playerArmor += 5;
                Destroy(gameObject);

            }
            if (playerHP.playerArmor > 50)
            {
                playerHP.playerArmor = 50;
            }


        }
    }
}
