using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mailBox : MonoBehaviour {
    
    public enum MailboxType { Neutral, Military, Rebel };
    public float score;
    public UnityEngine.UI.Text scoreText;
    public FactionOpinions factionOpinion;
    public MailboxType type;


    // Use this for initialization
    void Start()
    {
        score = 10.23f;
        scoreText.text = "€ " + string.Format("{0:.##}", score);

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnTriggerEnter(Collider col)
    {
        score = score + 0.5f;
        scoreText.text = "€ " + string.Format("{0:.##}", score);
        Destroy(col);
        if (type == MailboxType.Military) {
            factionOpinion.setMilitary(true);
            factionOpinion.setRebel(false);
        }
        else if (type == MailboxType.Rebel) {
            factionOpinion.setMilitary(false);
            factionOpinion.setRebel(true);
        }

        if(score > 14.0f)
        {
            SceneManager.LoadScene(4); //this will load our first level from our build settings. "1" is the second scene in our game
        }
    }

}