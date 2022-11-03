using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    Slider _healthSlider;

    PlayerHP playerHP;

    private void start()
    {
        _healthSlider = GetComponent<Slider>();
    }

    public void SetMaxHealth(int playerHP)
    {
        _healthSlider.maxValue = playerHP;
        _healthSlider.value = playerHP;
    }

    public void SetHealth(int health)
    {
        _healthSlider.value = health;
    }
}