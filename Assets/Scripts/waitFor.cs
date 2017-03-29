using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; // neded in order to load scenes


public class waitFor : MonoBehaviour
{

    // Use this for initialization
    public float timeLeft;
    private float time;
    public bool switchScene;
    public int scene;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0 || (Input.GetKey(KeyCode.Space)) )
        {
            SceneManager.LoadScene(scene); //this will load our first level from our build settings. "1" is the second scene in our game

        }


    }
}