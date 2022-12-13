using System;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public PlayerHP playerHP;
    public Animations animations;
    public sniperShoot snipershoot;
    public GameObject Player;


    private void Start()
    {
        Player = GameObject.Find("Player");
        playerHP = Player.gameObject.GetComponent<PlayerHP>();
        animations = Player.gameObject.GetComponent<Animations>();
        snipershoot = Player.gameObject.GetComponent<sniperShoot>();

    }

    public static event Action OnCollected;
    void Update()
    {

        if (gameObject.tag == ("Salt_Ammo") || gameObject.tag ==("Double_Barrel_Ammo"))
        {
        transform.Rotate(0f, 0f, 0.3f, Space.Self);
        }
        else
        {
        transform.Rotate(0f, 0.3f, 0f, Space.Self);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (playerHP == null)
        {
            playerHP = other.gameObject.GetComponent<PlayerHP>();
        }
        if (animations == null)
        {
            animations = other.gameObject.GetComponent<Animations>();
        }


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
        if (other.CompareTag("Player") && this.CompareTag("Salt_Ammo"))
        {
            OnCollected?.Invoke();
            if (animations.saltgunAmmo < 30)
            {
                animations.saltgunAmmo += 5;
                Destroy(gameObject);
            }
            if (animations.saltgunAmmo > 30)
            {
                animations.saltgunAmmo = 30;
            }
        }
        if (other.CompareTag("Player") && this.CompareTag("Double_Barrel_Ammo"))
        {
            OnCollected?.Invoke();
            if (animations.doubleBarrelAmmo < 30)
            {
                animations.doubleBarrelAmmo += 5;
                Destroy(gameObject);
            }
            if (animations.doubleBarrelAmmo > 30)
            {
                animations.doubleBarrelAmmo = 30;
            }
        }
            if (other.CompareTag("Player") && this.CompareTag("Sniper_Ammo"))
            {
                OnCollected?.Invoke();
                if (snipershoot.ammo < 20)
                {
                    snipershoot.ammo += 5;
                    Destroy(gameObject);
                }
                if (snipershoot.ammo > 20)
                {
                    snipershoot.ammo = 20;
                }
        }
    }
}


