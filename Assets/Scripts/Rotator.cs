using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

	private int score = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.Rotate(45f * Time.deltaTime, 0f, 0f);

	}

	void OnTriggerEnter(Collider other){
			
			if (other.CompareTag("Pickup")){
				Debug.Log("We are game");

				score ++;
				Debug.Log("Score: " + score);

				Destroy(gameObject);

			}

	}
	
}
