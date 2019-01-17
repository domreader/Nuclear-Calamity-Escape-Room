using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameLose : MonoBehaviour {

    [SerializeField]
    private Text uiTimer;

	// Use this for initialization
	void Start () {


    }
	
	// Update is called once per frame
	void Update () {

        double gameTime = Time.fixedTime;
        uiTimer.text = gameTime.ToString();

        if(gameTime >= 200.0f)
        {
            SceneManager.LoadScene("EndGame Lose");
        }

    }
}
