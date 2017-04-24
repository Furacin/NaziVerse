using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour {

	public GameObject player;
	bool fin = false;
	Vector3 init_position;

	// Use this for initialization
	void Start () {
		init_position = transform.position;
	}
	
	// Update is called once per frame
	void Update () { 
		if (player != null) {
			if (player.transform.position.x > -7f && !fin) {
				this.gameObject.transform.position = new Vector3 (player.gameObject.transform.position.x + 6.88f, this.gameObject.transform.position.y, this.gameObject.transform.position.z);
			}

			if (player.transform.position.x > 77f) {
				fin = true;
				this.gameObject.transform.position = new Vector3 (77f, this.gameObject.transform.position.y, this.gameObject.transform.position.z);
			}
		} else {
			this.gameObject.transform.position = init_position;
		}
	}
}
