﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class worldTimer : MonoBehaviour {

    // Use this for initialization
    public float timeLeft;
    private float time;
    Image image;
    public Canvas bigPanel;

    public UnityEngine.UI.Text scoreText;
    void Start () {
        bigPanel = bigPanel.GetComponent<Canvas>();
        image = this.GetComponent<Image>();
        timeLeft += 5;
        time = timeLeft;
        bigPanel.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(time - timeLeft > 5 && bigPanel.enabled)
        {
            bigPanel.enabled = false;
        }
        timeLeft -= Time.deltaTime;
        //scoreText.text = "Time left: " + timeLeft + " seconds.";
        image.fillAmount = timeLeft / time;
        scoreText.text = string.Format("{0:.#}",timeLeft);
        if (timeLeft < 0 || (Input.GetKey(KeyCode.Escape))
		)
        {
            Application.Quit();
        }


    }

    
  
}
