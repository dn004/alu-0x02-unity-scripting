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
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);
        rb.AddForce(movement * speed * Time.deltaTime);

        // Debug logs for diagnosis
        Debug.Log("Player Position: " + transform.position);
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger Enter! Other: " + other.gameObject.name);
    }

}
