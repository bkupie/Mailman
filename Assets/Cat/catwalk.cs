using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class catwalk : MonoBehaviour {

    public float speed          = 1;
    public float seedbase       = 1;
    public float directionChangeInterval = 1;
    public float HeadingRate = 13;
    float heading;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float rate = speed;

        var randomInt = Random.Range(1, 36);
        StartCoroutine(NewHeading());

        switch (randomInt)
        {
            case 1:
                Debug.Log(randomInt);
                this.GetComponent<Rigidbody>().velocity += this.transform.forward * rate * seedbase;
                break;
            case 3:
                Debug.Log(randomInt);
                this.GetComponent<Rigidbody>().rotation *= Quaternion.Euler(0, seedbase * rate, 0);
                break;
            case 4:
                Debug.Log(randomInt);
                this.GetComponent<Rigidbody>().rotation *= Quaternion.Euler(0, -seedbase * rate, 0);
                break;
        }
       	
	}

    IEnumerator NewHeading()
    {
        while (true)
        {
            NewHeadingRoutine();
            yield return new WaitForSeconds(seedbase);
        }
    }

    void NewHeadingRoutine()
    {
        var floor = Mathf.Clamp(heading - HeadingRate, 0, 360);
        var ceil = Mathf.Clamp(heading + HeadingRate, 0, 360);
        heading = Random.Range(floor, ceil);

    }

}
