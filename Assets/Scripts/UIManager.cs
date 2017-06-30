using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour {

    public void StartGame()
    {
        SceneManager.LoadScene("Jumpimg Bob");
    }

    public void LoadNextScene()
    {
        var current = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(current + 1);
    }

    public void ClickExit()

    {
        Debug.Log("Quiting");
        Application.Quit();

    }
}
