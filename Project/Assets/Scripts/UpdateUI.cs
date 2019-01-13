using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateUI : MonoBehaviour {

    bool isEntered;


    [SerializeField]
    private Text text;
    [SerializeField]
    private Text uiText;

    // Use this for initialization
    void Start () {

        bool isEntered;

        uiText.gameObject.SetActive(false);

    }
	
	// Update is called once per frame
	void Update () {

        if (isEntered == true)
        {
            uiText.gameObject.SetActive(true);

            uiText.text = ("Press E to Interact");
        }

        if (isEntered == false)
        {

            uiText.gameObject.SetActive(false);

        }

    }
}
