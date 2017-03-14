using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mailBox : MonoBehaviour {
    
    public enum MailboxType { Neutral, Military, Rebel };
    public float score;
    public UnityEngine.UI.Text scoreText;
    public FactionOpinions factionOpinion;
    public MailboxType type;


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
        if (type == MailboxType.Military) {
            factionOpinion.setMilitary(true);
            factionOpinion.setRebel(false);
        }
        else if (type == MailboxType.Rebel) {
            factionOpinion.setMilitary(false);
            factionOpinion.setRebel(true);
        }
    }

}