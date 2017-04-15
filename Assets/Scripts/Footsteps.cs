using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

public class Footsteps : MonoBehaviour {

    AudioSource source;

	// Use this for initialization
	void Start () {
        source = gameObject.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        bool moveKeyDown = Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.S);
        bool moveKeyUsed = Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.S);
        if (moveKeyDown) {
            source.Play();
        }
        else if (moveKeyUsed && !source.isPlaying) {
            source.PlayDelayed(0.15f);
        }
	}
}
