using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void LoadGame()
    {
        SceneManager.LoadScene("BasicScene");
    }
    public void returnToMenu()
    {
        SceneManager.LoadScene("Menu");

    }
}
