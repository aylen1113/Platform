using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5;
    public Rigidbody rb;
    public float jumpForce = 10;

    // Start is called before the first frame update
    void Start()
    {
     rb = GetComponent<Rigidbody>();   
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector3(Input.GetAxis("Horizontal") * speed, rb.velocity.y, Input.GetAxis("Vertical") * speed);

        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);
        
        }

    }
}
