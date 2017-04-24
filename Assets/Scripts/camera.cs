using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour {

	public GameObject player;
	bool fin = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () { 
		if (player.transform.position.x > -7f && !fin) {
			this.gameObject.transform.position = new Vector3 (player.gameObject.transform.position.x + 6.88f, this.gameObject.transform.position.y, this.gameObject.transform.position.z);
		}

		if (player.transform.position.x > 77f) {
			fin = true;
			this.gameObject.transform.position = new Vector3 (77f, this.gameObject.transform.position.y, this.gameObject.transform.position.z);
		}
	}
}
