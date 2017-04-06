using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

public class Footsteps : MonoBehaviour {

    AudioSource source;
    AudioSource sprint;

	// Use this for initialization
	void Start () {
        source = gameObject.GetComponent<AudioSource>();
	sprint = gameObject.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        //if () {
        if (Input.GetKeyDown(KeyCode.W)) {
            source.Play();
        }
        else if (Input.GetKey(KeyCode.W) && !source.isPlaying) {
            source.PlayDelayed(0.15f);
        }
	else if (Input.GetKeyDown(KeyCode.W)  && KeyCode.GetKeyDown(KeyCode.LeftShift) && !source.isPlaying && !sprint.isPlaying {
	    sprint.Play()		
        }
	}
}
