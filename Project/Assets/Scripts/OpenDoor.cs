using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenDoor : MonoBehaviour {

    Animation anim;
    Collider col;
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
    void Update()
    {

        if (isEntered == true)
        {

            uiText.gameObject.SetActive(true);

            uiText.text = ("Press E to open the door");
        }

        if (isEntered == false)
        {

            uiText.gameObject.SetActive(false);

        }

        if (Input.GetKeyDown(KeyCode.E) && isEntered == true)
        {
            this.GetComponent<Animator>().SetTrigger("isOpen");

            text.text = ("Game Complete");


            Debug.Log("In Collider");




        }


        if ( isEntered == true)
        {
            uiText.gameObject.SetActive(true);

            uiText.text = ("Press E to open the door");
        }

    }


    private void OnTriggerEnter(Collider other)
    {
        isEntered = true;
    }

    private void OnTriggerExit(Collider other)
    {
        isEntered = false;
    }

}
