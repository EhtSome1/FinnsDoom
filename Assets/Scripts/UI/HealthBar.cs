using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    Image healthBar;
    public int maxHealth = 50;
    public static float health;

    public PlayerHP HP;

    void Start()
    {
        healthBar = GetComponent<Image>();

    }

    private void Update()
    {
        health = HP.playerHP;
        healthBar.fillAmount = health / maxHealth;
        
    }
}


 