﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class credits : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Invoke ("Credits",6.5f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void Credits() {
		SceneManager.LoadScene("fin_game");
	}
}
