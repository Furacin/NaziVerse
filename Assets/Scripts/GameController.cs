using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState {Init, Playing};

public class GameController : MonoBehaviour {

	public GameState gameState = GameState.Init;
	public GameObject naziGenerator;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (gameState == GameState.Init) {
			gameState = GameState.Playing;
			naziGenerator.SendMessage ("StartGenerator");
		}
	}
}
