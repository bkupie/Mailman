using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactionOpinions : MonoBehaviour {

    //True means they like you
    public bool military;
    public bool rebel;

    public GameObject rebelTurf;
    public GameObject militaryTurf1;
    public GameObject militaryTurf2;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        rebelTurf.SetActive(!rebel);
        militaryTurf1.SetActive(!military);
        militaryTurf2.SetActive(!military);
	}

    public void setMilitary(bool opinion) {
        military = opinion;
    }

    public void setRebel(bool opinion) {
        rebel = opinion;
    }
}
