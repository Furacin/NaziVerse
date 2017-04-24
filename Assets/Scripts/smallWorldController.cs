using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class smallWorldController : MonoBehaviour {

	public GameObject character;
	public bool dialog = false;

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

			if (!dialog)
				StartDialog ();

			if (Input.GetKey (KeyCode.E))
				SceneManager.LoadScene ("level2");
		}
	}
		

	void StartDialog() {
		dialog = true;
		Invoke ("showDialog1",1.5f);
	}

	void showDialog1() {
		dialog1.SetActive(true);
		Invoke ("showDialog2",5f);
	}

	void showDialog2() {
		dialog1.SetActive(false);
		dialog2.SetActive(true);
		Invoke ("showDialog3",5f);
	}

	void showDialog3() {
		dialog2.SetActive(false);
		dialog3.SetActive(true);
		Invoke ("showDialog4",5f);
	}

	void showDialog4() {
		dialog3.SetActive(false);
		dialog4.SetActive(true);
		Invoke ("endDialog",5f);
	}

	void endDialog() {
		dialog4.SetActive(true);
	}
}
