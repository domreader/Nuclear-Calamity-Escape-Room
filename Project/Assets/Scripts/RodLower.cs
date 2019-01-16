using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RodLower : MonoBehaviour {

    bool consoleRange;

    [SerializeField]
    private Text text;
    [SerializeField]
    private Text uiText;

    // Use this for initialization
    void Start () {

        uiText.gameObject.SetActive(true);


    }

    // Update is called once per frame
    void Update () {


        if (consoleRange == true)
        {

            uiText.gameObject.SetActive(true);

            uiText.text = ("Press Q to lower rods");
        }


        if (consoleRange == false)
        {

            uiText.gameObject.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Q) && consoleRange == true)
        {

            text.text = ("You have activated the rods, ESCAPE!");

        }

        if (Input.GetKeyDown(KeyCode.E) && consoleRange == false)
        {


        }
    }

    private void OnTriggerEnter(Collider other)
    {
        consoleRange = true;

    }

    private void OnTriggerExit(Collider other)
    {
        consoleRange = false;
    }
}
