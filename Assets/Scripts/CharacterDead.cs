using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterDead : MonoBehaviour {

	private string name_scene;

	// Use this for initialization
	void Start () {
		Scene scene = SceneManager.GetActiveScene ();
		name_scene = scene.name;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.tag == "nazibullet") {
			if (name_scene == "escena") 
				SceneManager.LoadScene ("RestartLevel1");
			else if (name_scene == "level2")
				SceneManager.LoadScene ("RestartLevel2");
			
				Destroy(gameObject);
				Destroy(other.gameObject);
		}
	}
}
