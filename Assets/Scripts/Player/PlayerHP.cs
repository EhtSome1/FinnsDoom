using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHP : MonoBehaviour
{
    public int playerHP = 100;
    public int playerArmor = 50;
    public Object sceneToLoad;
    int overDamage;

    public Timer timer;
    public Playermovement move;

    void Start()
    {
        move = move.GetComponent<Playermovement>();
    }

    void Update()
    {
        if (playerHP <= 0)
        {
            Destroy(gameObject);
            Destroy(timer.gameObject);
            move.canMove = false;
            SceneManager.LoadScene(sceneToLoad.name);
            Cursor.lockState = CursorLockMode.Confined;

}

    }
}
