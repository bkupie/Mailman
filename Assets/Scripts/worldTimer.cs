using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class worldTimer : MonoBehaviour {

    // Use this for initialization
    public float timeLeft;
    private float time;
    Image image;
    public Canvas bigPanel;
    private bool spacePressed;

    public UnityEngine.UI.Text scoreText;
    void Start () {
        bigPanel = bigPanel.GetComponent<Canvas>();
        image = this.GetComponent<Image>();
        timeLeft += 10;
        time = timeLeft;
        bigPanel.enabled = true;
        spacePressed = false;
    }

    // Update is called once per frame
    void Update()
    {
        if((time - timeLeft > 40 && bigPanel.enabled) || Input.GetKey(KeyCode.Space) && spacePressed == false)
        {
            bigPanel.enabled = false;
            timeLeft = time;
            spacePressed = true;
        }
        timeLeft -= Time.deltaTime;
        //scoreText.text = "Time left: " + timeLeft + " seconds.";
        image.fillAmount = timeLeft / time;
        scoreText.text = string.Format("{0:.#}",timeLeft);
        if (timeLeft < 0 )
        {
            SceneManager.LoadScene(5);
        }
        if(Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }


    }

    
  
}
