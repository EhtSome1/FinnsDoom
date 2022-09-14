using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHP : MonoBehaviour
{
    public int playerHP = 100;
    public int playerArmor = 50;

    int overDamage;

    public Playermovement move;


    void Start()
    {
        move = move.GetComponent<Playermovement>();
    }

    void Update()
    {
        if (playerHP <= 0)
        {
            move.canMove = false;
        }
    }
}
