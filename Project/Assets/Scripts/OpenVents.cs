﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenVents : MonoBehaviour {


    bool ventConsoleRange;

    [SerializeField]
    private Text text;
    [SerializeField]
    private Text uiText;


    // Use this for initialization
    void Start () {


        uiText.gameObject.SetActive(true);


    }

    // Update is called once per frame
    void Update()
    {

        if (ventConsoleRange == true)
        {

            uiText.gameObject.SetActive(true);

            uiText.text = ("Press R to open the door");
        }

        if (ventConsoleRange == false)
        {

            uiText.gameObject.SetActive(false);

        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            this.GetComponent<Animator>().SetTrigger("ventUp");

            text.text = ("Now Slow Down Reactions");

            Debug.Log("In Collider");

        }

    }

    private void OnTriggerEnter(Collider other)
    {
        ventConsoleRange = true;

    }

    private void OnTriggerExit(Collider other)
    {
        ventConsoleRange = false;
    }

}

