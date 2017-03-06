sing System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MailController : MonoBehaviour
{

    public float speed = 10;
    public double height = 1;
    public GameObject envelope;
    public double projectileSpeed = 1;
    // Use this for initialization

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float multipler = speed;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var mail = GameObject.Instantiate(envelope, this.transform.position, Quaternion.identity) as GameObject;
            var objectCollider = this.GetComponentsInChildren<Collider>();
            foreach (var collider in objectCollider)
            {
                Physics.IgnoreCollision(mail.GetComponent<Collider>(), collider);
            }

            mail.GetComponent<Rigidbody>().velocity = transform.forward * -30 * (float)projectileSpeed;
            //ball.GetComponent<Rigidbody>().velocity += Vector3.up * 10 * (float)height;
            // so the mail drops with physics
            this.GetComponent<Rigidbody>().AddForce(transform.forward * -800 * multipler);

        }
    }
}