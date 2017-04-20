using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class moveTextUp : MonoBehaviour {
    Vector3 temp;

    public Text myText; 
	// Use this for initialization
	void Start () {
		temp = new Vector3(0, 1.0f, 0);
    }
	
	// Update is called once per frame
	void Update () {

	        myText.transform.position += temp;

    }
}
