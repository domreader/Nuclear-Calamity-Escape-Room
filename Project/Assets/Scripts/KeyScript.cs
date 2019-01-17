using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class KeyScript : MonoBehaviour {


    bool holdingKey;
    bool keyRange;
    bool usedKey;

    [SerializeField]
    GameObject Key;


    [SerializeField]
    private Text text;
    [SerializeField]
    private Text uiText;


    // Use this for initialization
    void Start () {

        bool holdingKey;

        uiText.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update () {

        if (keyRange == true)
        {

            uiText.gameObject.SetActive(true);

            uiText.text = ("Press E to open the door");
        }

        if (keyRange == false)
        {

            uiText.gameObject.SetActive(false);

        }


        if (Input.GetKeyDown(KeyCode.E) && keyRange == true)
        {

            Destroy(Key);


            text.text = ("You have the book, now activate the panel");

           

            Debug.Log(holdingKey);

        }

        

        if(Input.GetKeyDown(KeyCode.Q) && gameObject.CompareTag("Key") == false)
        {

            text.text = ("You have activated the rods, ESCAPE!");

        }

        if (Input.GetKeyDown(KeyCode.E) && holdingKey == true)
        {

            text.text = ("You have activated the rods, now unlock the door");

            // holdingKey = false;

        }

        if (keyRange == true)
        { 
        
            uiText.gameObject.SetActive(true);

            uiText.text = ("Press E to pick the key up");
        }


        if (keyRange == false)
        {

            uiText.gameObject.SetActive(false);

            uiText.text = ("");

        }

    

            if (Input.GetKeyDown(KeyCode.Escape))
            {
                SceneManager.LoadScene("MenuScreen");
            }

       


    }



    private void isNotHoldingKey()
    {
        holdingKey = false;
    }

  


    private void OnTriggerEnter(Collider collider)
    {
        keyRange = true;

    }

    private void OnTriggerExit(Collider collider)
    {
        keyRange = false;
    }

    


}
