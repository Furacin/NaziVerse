using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenNaziDead : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D(Collider2D other) {
		Debug.Log ("Colisión con el límite del escenario");
		if (other.gameObject.tag == "bullet") {
			Destroy(gameObject);
			Destroy(other.gameObject);
		}
	}
}
