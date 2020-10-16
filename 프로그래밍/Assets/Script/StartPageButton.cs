using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartPageButton : MonoBehaviour {
    
    public void Game_Start()
    {
        SceneManager.LoadScene("Basecamp");
    }

    public void Game_End()
    {
        Application.Quit();
    }
}
