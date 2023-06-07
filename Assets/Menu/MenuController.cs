using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public GameObject Item;
    private void Start()
    {
        for (int i = 0; i <10;i++)
        {
            Instantiate(Item);
        }
    }
    public void StartGame()
    {
        // Load the game scene
        SceneManager.LoadScene("Game");
    }

    public void OpenOptions()
    {
        // Implement options functionality here
        Debug.Log("Options button clicked");
    }

    public void ExitGame()
    {
        // Quit the application
        Application.Quit();
    }
}
