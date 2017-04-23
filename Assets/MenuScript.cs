using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour {


	public void changemenuscene(string scene) {
		Application.LoadLevel (scene);
	}

	public void exitgame() {
		Application.Quit();
	}
}
