using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHP : MonoBehaviour
{
    public int playerHP = 100;
    public int playerArmor = 50;

    int overDamage;

    public Playermovement move;

    /*void OnControllerColliderHit(ControllerColliderHit collision)
    {
        Debug.Log("Player hit" + collision.gameObject.tag + collision.gameObject.layer);
        if (collision.gameObject.layer == 6)
        {
            switch (collision.gameObject.tag)
            {
                case "hytty" :
                    if (playerArmor > 0)
                    {
                        playerArmor -= 5;
                    }
                    if (playerArmor < 0)
                    {
                        overDamage = -playerArmor;

                        playerHP -= overDamage;
                    }
                    else if(playerArmor <= 0)
                    {
                        playerHP -= 5;
                    }

                    break;

            }

        }
    }*/


    // Start is called before the first frame update
    void Start()
    {
        move = move.GetComponent<Playermovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerHP <= 0)
        {
            move.canMove = false;
        }
    }
}
