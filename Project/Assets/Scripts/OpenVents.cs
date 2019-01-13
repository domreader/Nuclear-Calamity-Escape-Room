using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenVents : MonoBehaviour {


    Animation anim;

    [SerializeField]
    private Text text;


    // Use this for initialization
    void Start () {
	
        
        

	}

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.R))
        {
            this.GetComponent<Animator>().SetTrigger("ventUp");

            text.text = ("Slow Down Reactions");

            Debug.Log("In Collider");

        }

    }
}
