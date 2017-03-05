using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float rotationSpeed;
    public float rotX;
    public float rotY;
    public float maxLookUpAngle;
    public float maxLookDownAngle;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        rotX += Input.GetAxis("Mouse X") * rotationSpeed;
        rotY += -Input.GetAxis("Mouse Y") * rotationSpeed;
        if (rotY > maxLookUpAngle) rotY = maxLookUpAngle;
        if (rotY < maxLookDownAngle) rotY = maxLookDownAngle;

        gameObject.transform.rotation = Quaternion.Euler(rotY, rotX, 0.0f);
	}
}
