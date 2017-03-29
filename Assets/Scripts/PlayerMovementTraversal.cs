using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementTraversal : MonoBehaviour {

    public float accel;
    Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = gameObject.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
    void Update() {
        Vector3 childForward = transform.GetChild(0).gameObject.transform.forward;
        Vector3 childRight = transform.GetChild(0).gameObject.transform.right;
        childForward.y = 0; childRight.y = 0;
        if(rb.velocity.magnitude < 5.0f && Input.GetKey(KeyCode.W))
            rb.AddForce(childForward * accel);
        if (rb.velocity.magnitude < 5.0f && Input.GetKey(KeyCode.S))
            rb.AddForce(-childForward * accel);
        if (rb.velocity.magnitude < 5.0f && Input.GetKey(KeyCode.A))
            rb.AddForce(-childRight * accel);
        if (rb.velocity.magnitude < 5.0f && Input.GetKey(KeyCode.D))
            rb.AddForce(childRight * accel);
	}
}
