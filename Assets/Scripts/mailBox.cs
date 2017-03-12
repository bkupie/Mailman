using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mailBox : MonoBehaviour
{
    public float score;
    public UnityEngine.UI.Text scoreText;
    // Use this for initialization
    void Start()
    {
        score = 10.0f;
        scoreText.text = "Money: $" + string.Format("{0:.#}", score) + "\nHealth: 10 / 10";

    }

    // Update is called once per frame
    void Update()
    {

    }


    void OnTriggerEnter(Collider col)
    {
        score = score + 0.5f;
        scoreText.text = "Money: $" + string.Format("{0:.#}", score) + "\nHealth: 10 / 10";
        Destroy(col);

    }

}