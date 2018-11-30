using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	// Use this for initialization
	private void StartGame () {

        SceneManager.LoadScene("Main Game");

	}
	
	private void MenuScreen()
    {

        SceneManager.LoadScene("Menu Screen");

    }

}
