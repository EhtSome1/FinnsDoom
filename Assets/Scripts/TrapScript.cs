using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapScript : MonoBehaviour
{
    GameObject Player;
    public PlayerHP playerhp;
    public int LavaDamage = 5;
    public float TrapSlow = 4f;
    float startTime;
    public Playermovement playermovement;
    private void Start()
    {
        Player = GameObject.Find("Player");
        playerhp = Player.gameObject.GetComponent<PlayerHP>();
        playermovement = Player.gameObject.GetComponent<Playermovement>();

    }
    public void PlayerTakesDamage()
    {
        playerhp.playerHP -= LavaDamage;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player") && this.CompareTag("Lava"))
        {
            playermovement.speed = TrapSlow;
            if (Time.time > startTime + 0.5f)
            {
                startTime = Time.time;
                PlayerTakesDamage();
            }
        }
    }

   


}
