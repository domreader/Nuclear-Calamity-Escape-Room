using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitCollider : MonoBehaviour {

    bool inCollider;

    // Use this for initialization
    void Start () {
		


	}
	
	// Update is called once per frame
	void Update () {
		
        if(inCollider == true)
        {



            SceneManager.LoadScene("EndGame Win");
        }


	}


    private void OnTriggerEnter(Collider other)
    {
        inCollider = true;
    }

}
