using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

	public float speed = 2.5f;
	private Animator animator;
	bool collision = false;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> (); // Obtenemos la componente animator del objeto
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.LeftArrow)) { // LEFT
			transform.position += Vector3.left * speed * Time.deltaTime;
			animator.StopPlayback ();
			UpdateState ("move_character_left_gun");
		} else if (Input.GetKey (KeyCode.RightArrow)) { // RIGHT
			if (collision) { // Si estamos en el borde del escenario, para moverse
				speed = 2.5f;
			}
			transform.position += Vector3.right * speed * Time.deltaTime;
			animator.StopPlayback ();
			UpdateState ("move_character_right_gun");
		} else if (Input.GetKey (KeyCode.Z)) { // JUMP (Z)
			//transform.position.y
		} else
			UpdateState("idle_gun_character");
	}

	public void UpdateState(string state = null) {
		if (state != null) {
			animator.Play(state); // Ejecutar la animación pasada como parámetro
		}
	}

	void OnTriggerEnter2D(Collider2D other) {
		Debug.Log("Colisión con el límite del escenario");
		if (other.gameObject.tag == "brick") {
			collision = true;
			speed = 0;
		}
	}

}
