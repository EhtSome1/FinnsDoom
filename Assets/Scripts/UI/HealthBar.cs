using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Playermovement playermovement;
    Image healthBar;
    public int maxHealth = 50;
    public static float health;

    public PlayerHP HP;

    void Start()
    {
        healthBar = GetComponent<Image>();
        playermovement = playermovement.gameObject.GetComponent<Playermovement>();
    }

    private void Update()
    {
        health = HP.playerHP;
        healthBar.fillAmount = health / maxHealth;
        
    }
}


 