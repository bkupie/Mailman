using UnityEngine;
using UnityEngine.UI;// we need this namespace in order to access UI elements within our script
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement; // neded in order to load scenes

public class MailController : MonoBehaviour
{
    // Use this for initialization
    public float speed = 10;
    public double height = 1;
    public float lengthOfHold = 4.0f;
    public GameObject envelope;
    public double projectileSpeed = 1;
    public Image myMail;

    void Start()
    {
        myMail.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        float multipler = speed;
        if (Input.GetKeyDown(KeyCode.M))
            StartCoroutine(ThrowMail());
        


    }
    IEnumerator ThrowMail()
    {
        var savePos = this.transform.position;
        this.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 1);
        float multipler = speed;
        var mail = GameObject.Instantiate(envelope, this.transform.position + transform.forward * 30 * Time.deltaTime, Quaternion.identity) as GameObject;
        var objectCollider = this.GetComponentsInChildren<Collider>();
        mail.GetComponent<Transform>().LookAt(this.transform.position);
        // freeze mail so we can inspect it
        mail.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezePositionY;
        // delay for 2 seconds so we can inspect the mail 

        yield return new WaitForSeconds(lengthOfHold);
        myMail.enabled = true;
        yield return new WaitForSeconds(lengthOfHold);
        myMail.enabled = false;
        yield return new WaitForSeconds(lengthOfHold);
        mail.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;

        foreach (var collider in objectCollider)
        {
            Physics.IgnoreCollision(mail.GetComponent<Collider>(), collider);
        }
        
        mail.GetComponent<Rigidbody>().velocity = transform.forward * 30 * (float)projectileSpeed;
        mail.GetComponent<Rigidbody>().velocity += Vector3.up * 5 * (float)height;
        yield return new WaitForSeconds(lengthOfHold);
        this.transform.position = savePos;

    }

}

  