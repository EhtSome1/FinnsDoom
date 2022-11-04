using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flamethrowerdamage : MonoBehaviour
{
    GameObject Player;
    PlayerHP playerHP;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
        playerHP = Player.gameObject.GetComponent<PlayerHP>();
    }

    void OnParticleCollision(GameObject other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerHP.playerHP --;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
