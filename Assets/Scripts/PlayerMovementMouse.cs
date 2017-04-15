using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementMouse : MonoBehaviour {

    public float rotationSpeed;
    private float rotX = 0.0f;
    private float rotY = 0.0f;
    public float maxLookUpAngle;
    public float maxLookDownAngle;

	// Use this for initialization
	void Start () {
        Vector3 startRotation = transform.localRotation.eulerAngles;
        rotY = startRotation.y;
        rotX = startRotation.x;
	}
	
	// Update is called once per frame
    void Update() {

        rotY += Input.GetAxis("Mouse X") * rotationSpeed;
        rotX -= Input.GetAxis("Mouse Y") * rotationSpeed;
        if (rotX > maxLookUpAngle) rotX = maxLookUpAngle;
        if (rotX < maxLookDownAngle) rotX = maxLookDownAngle;

        gameObject.transform.parent.rotation = Quaternion.Euler(0.0f, rotY, 0.0f);
        //gameObject.transform.parent.rotation = Quaternion.Euler(0.0f, 90.0f, 0.0f);
        transform.rotation = Quaternion.Euler(rotX, rotY, 0.0f);

        if (Input.GetKey(KeyCode.S)) {
        }
        
        /*rotX += Input.GetAxis("Mouse X") * rotationSpeed;
        rotY += -Input.GetAxis("Mouse Y") * rotationSpeed;
        if (rotY > maxLookUpAngle) rotY = maxLookUpAngle;
        if (rotY < maxLookDownAngle) rotY = maxLookDownAngle;

        gameObject.transform.rotation = Quaternion.identity;
        gameObject.transform.rotation = Quaternion.Euler(rotY, rotX, 0.0f);*/
        //gameObject.transform.parent.transform.rotation = Quaternion.Euler(0, rotX, 0.0f);
            
	}
}
