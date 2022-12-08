using UnityEngine;

public class Projectile : MonoBehaviour
{
    GameObject Player;
    public PlayerHP playerhp;
    public int projectileDamage;
    public float projectileSpeed;
    float destroyTime = 10;

    private void Start()
    {
        Player = GameObject.Find("Player");
        playerhp = Player.gameObject.GetComponent<PlayerHP>();
    }
    void Update()
    {
        destroyTime -= Time.deltaTime;
        if (destroyTime <= 0)
        {
            Destroy(gameObject);
        }

        transform.position += transform.forward * projectileSpeed * Time.deltaTime;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log(playerhp.playerHP);
            playerhp.playerHP -= projectileDamage;
            Destroy(gameObject);
        }

    }
}