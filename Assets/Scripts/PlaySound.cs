using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlaySound : MonoBehaviour {

    public AudioClip soundToPlay;
    public float volume;
    AudioSource audio;
    public bool alreadyPlayed = false;
    public Canvas textBox;
 

	// Use this for initialization
	void Start () {
        audio = GetComponent<AudioSource>();
        textBox = textBox.GetComponent<Canvas>();
        textBox.enabled = false;
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.X))
        {
            textBox.enabled = false;// !textBox.enabled;
        }
    }


	// Update is called once per frame
	void OnTriggerEnter() {
        if(!alreadyPlayed)
        {
            audio.PlayOneShot(soundToPlay, volume);
            textBox.enabled = true;
            alreadyPlayed = true;
        }
		
	}
}