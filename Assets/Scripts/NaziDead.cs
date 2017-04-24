using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaziDead : MonoBehaviour {

	//public GameObject gameController;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.tag == "bullet") {
			Destroy(gameObject);
			Destroy(other.gameObject);
			//gameController.SendMessage ("AddDeath");
		}
	}
}
