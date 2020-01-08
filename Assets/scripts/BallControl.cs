 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    public float moveStrenght;
    public float jumpStrenght;

    bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionStay(Collision collison)
    {
        isGrounded = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        if(isGrounded) {
            isGrounded = false;
        }
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space") && isGrounded)
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * jumpStrenght);
        }
        if (Input.GetKey("w"))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.forward * moveStrenght);
        }
        if (Input.GetKey("a"))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.left * moveStrenght);
        }
        if (Input.GetKey("s"))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.back * moveStrenght);
        }
        if (Input.GetKey("d"))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.right * moveStrenght);
        }
    }
}
