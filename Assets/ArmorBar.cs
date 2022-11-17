using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArmorBar : MonoBehaviour
{

    public Image armorBar;
    public int maxArmor = 50;
    public static float Armor;

    public PlayerHP playerArmor;
    void Start()
    {
        playerArmor = playerArmor.gameObject.GetComponent<PlayerHP>();
        armorBar = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()

    {
        Armor = playerArmor.playerArmor;
        armorBar.fillAmount = Armor / maxArmor;
    }
}


