using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class WorldSwitcher : MonoBehaviour
{

    public Object sceneToLoad;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") /*&& this.CompareTag("WorldSwitch")*/)
        {
            SceneManager.LoadScene(sceneToLoad.name);
        }
        if (other.tag == "Player" && other.tag == "Ovi")
        {
            SceneManager.LoadScene("The_fourth_map");
        }
    }
}