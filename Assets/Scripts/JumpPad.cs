using UnityEngine;

public class JumpPad : MonoBehaviour
{
    GameObject Player;
    public Playermovement playermovement;

    void Start()
    {
        Player = GameObject.Find("Player");
        playermovement = Player.gameObject.GetComponent<Playermovement>();
      
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && this.CompareTag("Jump_Pad"))
        {
            Debug.Log("toimii");
            playermovement.jumpHeight = 5f;

        }
    }

    private void OnTriggerExit(Collider other)
    {
        playermovement.jumpHeight = 1f;

    }
}







