using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControllerLevel2 : MonoBehaviour {

	public GameState gameState = GameState.Init;
	public GameObject greenNaziGenerator;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (gameState == GameState.Init) {
			gameState = GameState.Playing;
			greenNaziGenerator.SendMessage ("StartGenerator");
		}
	}
}
