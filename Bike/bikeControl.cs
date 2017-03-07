using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bikeControl : MonoBehaviour {

	public float speed         = 30;
	public float rotationSpeed = 105;


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		float rate = speed;

		// Shift used as spring, W, A, S, D movement.
		if (Input.GetKey (KeyCode.LeftShift))
			rate *= 2;
		if (Input.GetKey (KeyCode.W))
			this.GetComponent<Rigidbody>().velocity += this.transform.forward * rate * Time.deltaTime;
		if (Input.GetKey (KeyCode.S))
			this.GetComponent<Rigidbody>().velocity += this.transform.forward * -rate * Time.deltaTime;
		if (Input.GetKey (KeyCode.D))
			this.GetComponent<Rigidbody>().rotation *= Quaternion.Euler(0, rotationSpeed * Time.deltaTime, 0);
		if (Input.GetKey (KeyCode.A))
			this.GetComponent<Rigidbody>().rotation *= Quaternion.Euler(0, -rotationSpeed * Time.deltaTime, 0);

		//Logic for bike lean?


		//GameObject shell = GameObject.Instantiate(tank_round, this.transform  Quaternion.identy) as GameObject;
	}
}