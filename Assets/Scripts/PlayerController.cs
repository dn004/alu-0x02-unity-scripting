using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 1000f;
	

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Get input for movement
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Calculate movement vector (no vertical movement)
        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);

        // Apply force to the rigidbody for movement with Time.deltaTime
        rb.AddForce(movement * speed * Time.deltaTime);

        
    }
}
