using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState {Init, Playing, Genrerar1, Generar2, Generar3};

public class GameController : MonoBehaviour {

	int contador_nazis = 0;

	public GameObject character;

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

		if (character != null && gameState == GameState.Playing && character.transform.position.x > 5f) {
			Destroy (naziGenerator);
		}

		// Segunda Oleada
		/*if (gameState == GameState.Playing && character.transform.position.x > 5f) {
			naziGenerator.SendMessage ("CancelGenerator");
			//Destroy(naziGenerator);
			Debug.Log ("SEGUNDA OLEADA");
			Vector3 position = naziGenerator.transform.position;

			naziGenerator.transform.position = position;
			//naziGenerator.transform.position.x += 34f;
			naziGenerator.SendMessage ("StartGenerator");
		}

		// Tercera Oleada
		if (gameState == GameState.Playing && contador_nazis == 30) {
			//naziGenerator3.SendMessage ("StartGenerator");
		}*/
	}
}
