using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class smallWorldController : MonoBehaviour {

	public GameObject character;

	public GameObject dialog1;
	public GameObject dialog2;
	public GameObject dialog3;
	public GameObject dialog4;

	// Use this for initialization
	void Start () {
		dialog1.SetActive(false);
		dialog2.SetActive(false);
		dialog3.SetActive(false);
		dialog4.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log (character.transform.position.x);
		if (character.transform.position.x > 1.5f) {
			/*dialog1.SetActive (true);
			if (Input.GetKey (KeyCode.Space)) {
				dialog1.SetActive (true);
			}*/

			if (Input.GetKey (KeyCode.E))
				SceneManager.LoadScene ("level2");
		}
	}

	void OnTriggerEnter2D(Collider2D other) {
		/*if (other.gameObject.tag == "character") {
			dialog1.SetActive(true);
		}*/
	}
}
