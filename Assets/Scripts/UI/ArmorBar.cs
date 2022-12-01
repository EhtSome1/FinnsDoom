using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArmorBar : MonoBehaviour
{
    public Image armorBar;
    public int maxArmor = 50;
    public float Armor;

    public PlayerHP playerArmor;

    GameObject player;
    void Start()
    {
        player = GameObject.Find("Player");
        playerArmor = player.gameObject.GetComponent<PlayerHP>();
        armorBar = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()

    {
        Armor = playerArmor.playerArmor;
        armorBar.fillAmount = Armor / maxArmor;
    }
}


