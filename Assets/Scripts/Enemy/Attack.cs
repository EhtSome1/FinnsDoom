using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public GameObject player;
    GameObject armorBarInner;
    GameObject healthBarInner;

    PlayerHP playerHP;

    ArmorBar armorBar;
    HealthBar healthBar;

    int overDamage;

    public int attackDamage = 50;

    bool canAttack = true;

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" && canAttack)
        {
            canAttack = false;

            if (playerHP.playerArmor > 0)
            {
                playerHP.playerArmor -= attackDamage;
                armorBar.Armor -= attackDamage;
            }
            if (playerHP.playerArmor > 0)
            {
                overDamage = -playerHP.playerArmor;

                playerHP.playerHP -= overDamage;
                healthBar.health -= overDamage;

                playerHP.playerArmor = 0;
            }
            else if (playerHP.playerArmor <= 0)
            {
                playerHP.playerHP -= attackDamage;
            }

            Invoke("enableAttack", 1f);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        armorBarInner = GameObject.Find("ArmorBarInner");
        healthBarInner = GameObject.Find("ArmorBarInner");

        player = GameObject.Find("Player");

        playerHP = player.GetComponent<PlayerHP>();

        armorBar = armorBarInner.gameObject.GetComponent<ArmorBar>();
        healthBar = healthBarInner.gameObject.GetComponent<HealthBar>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void enableAttack()
    {
        canAttack = true;
    }
}