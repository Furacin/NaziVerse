﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour {

	public float velocity = 10f;
	private Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {
		rb2d = gameObject.GetComponent<Rigidbody2D> ();
		rb2d.velocity = Vector2.right * velocity;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
