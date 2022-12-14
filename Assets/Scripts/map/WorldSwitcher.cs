using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class WorldSwitcher : MonoBehaviour
{

    public Object sceneToLoad;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player") /*&& this.CompareTag("WorldSwitch")*/
        {
            SceneManager.LoadScene(sceneToLoad.name);
        }
    }

}
