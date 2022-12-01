using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Image healthBar;
    public int maxHealth = 50;
    public static float health;

    public PlayerHP HP;

    void Start()
    {
        HP = HP.gameObject.GetComponent<PlayerHP>();
        healthBar = GetComponent<Image>();

    }

    private void Update()
    {
        health = HP.playerHP;
        healthBar.fillAmount = health / maxHealth;

    }
}


