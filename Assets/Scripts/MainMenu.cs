using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
        // Old Code for LoadScene: SceneManager.GetActiveScene().buildIndex + 1
        // Changed it to 1 so that LoadScene can be called from all Scenes
    }

    public void QuitGame()
    {
        Debug.Log("QUIT ");
        Application.Quit();
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }







    // // Start is called before the first frame update
    // void Start()
    // {

    // }

    // // Update is called once per frame
    // void Update()
    // {

    // }
}
