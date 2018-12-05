using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	// Use this for initialization
	public void StartGame () {

        SceneManager.LoadScene("MainGame");

	}
	
	public void MenuScreen()
    {

        SceneManager.LoadScene("MenuScreen");

    }

    public void Settings ()
    {

        SceneManager.LoadScene("Settings");

    }

    public void QuitGame ()
    {

        Application.Quit();

    }

}
