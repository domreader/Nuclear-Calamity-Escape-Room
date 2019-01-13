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

    // Use this for initialization
    void Start () {

        bool isEntered;

	}

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.E) && isEntered == true)
        {
            this.GetComponent<Animator>().SetTrigger("isOpen");

            text.text = ("Game Complete");

            Debug.Log("In Collider");

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
