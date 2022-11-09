using UnityEngine;
using UnityEngine.UI;

public class ArmorBar : MonoBehaviour
{
    public Playermovement playermovement;
    Image armorBar;
    public int maxArmor = 50;
    public static float armor;

    public PlayerHP HP;

    void Start()
    {
        armorBar = GetComponent<Image>();
        playermovement = playermovement.gameObject.GetComponent<Playermovement>();
    }

    private void Update()
    {
        armor = HP.playerHP;
        armorBar.fillAmount = armor / maxArmor;

    }
}


