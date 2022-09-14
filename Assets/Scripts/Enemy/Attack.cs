using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public GameObject player;

    PlayerHP playerHP;

    int overDamage;

    bool canAttack = true;

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" && canAttack)
        {
            canAttack = false;

            if (playerHP.playerArmor > 0)
            {
                playerHP.playerArmor -= 30;
            }
            if (playerHP.playerArmor < 0)
            {
                overDamage = -playerHP.playerArmor;

                playerHP.playerHP -= overDamage;
            }
            else if (playerHP.playerArmor <= 0)
            {
                playerHP.playerHP -= 30;
            }

            Invoke("enableAttack", 1f);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        playerHP = player.GetComponent<PlayerHP>();
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
