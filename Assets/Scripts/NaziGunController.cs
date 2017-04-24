using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaziGunController : MonoBehaviour {

	public float velocity = 8f;
	private Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {
		rb2d = gameObject.GetComponent<Rigidbody2D> ();
		rb2d.velocity = Vector2.left * velocity;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
