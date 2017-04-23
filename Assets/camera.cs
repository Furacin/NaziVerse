using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour {

	public GameObject player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () { 
		if (player.transform.position.x > 0.2f) {
			this.gameObject.transform.position = new Vector3 (player.gameObject.transform.position.x, this.gameObject.transform.position.y, this.gameObject.transform.position.z);
		}
	}
}
