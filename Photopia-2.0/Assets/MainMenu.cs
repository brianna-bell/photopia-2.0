using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string Leveltoload = "Speeding";

    public void Play()
    {
        SceneManager.LoadScene(Leveltoload);
    }

    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
