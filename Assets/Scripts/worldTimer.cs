using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class worldTimer : MonoBehaviour {

    // Use this for initialization
    public float timeLeft;
    public UnityEngine.UI.Text scoreText;
    void Start () {
       
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        //scoreText.text = "Time left: " + timeLeft + " seconds.";
        scoreText.text = "Time left: " + string.Format("{0:.#}",timeLeft);
        if (timeLeft < 0 || (Input.GetKey(KeyCode.Escape))
		)
        {
            Application.Quit();
        }


    }

    
  
}
