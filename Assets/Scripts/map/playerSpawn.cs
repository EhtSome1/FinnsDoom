using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerSpawn : MonoBehaviour
{
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("moveplayer", 0.2f);
    }

    void moveplayer()
    {
        player = GameObject.Find("Player");

        Debug.Log(player.name);

        player.transform.position = gameObject.transform.position;

        Debug.Log("Moved the player to spawn");
    }
}
