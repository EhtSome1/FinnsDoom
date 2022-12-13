using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Image healthBar;
    public int maxHealth = 50;
    public float health;

    public PlayerHP HP;

    GameObject player;

    void Start()
    {
        player = GameObject.Find("Player");
        HP = player.gameObject.GetComponent<PlayerHP>();
        healthBar = GetComponent<Image>();

    }

    private void Update()
    {
        health = HP.playerHP;
        healthBar.fillAmount = health / maxHealth;

    }
}


