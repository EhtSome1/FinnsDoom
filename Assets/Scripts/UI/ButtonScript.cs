using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ButtonScript : MonoBehaviour
{
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void Options()
    {
        SceneManager.LoadScene("Options");
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(2);
        Debug.Log("Scene vaihdettu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }



}
