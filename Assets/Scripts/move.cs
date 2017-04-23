using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

	public GameObject bulletPrefab;

	public float speed = 2.5f;
	private Animator animator;
	bool collision = false;
	public float jumpPower = 2.5f;
	private bool jump;
	bool grounded = false;

	private Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {
		
		animator = GetComponent<Animator> (); // Obtenemos la componente animator del objeto
		rb2d = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {

		animator.SetBool("Grounded",grounded);

		if (Input.GetKey (KeyCode.LeftArrow)) { // LEFT
			transform.position += Vector3.left * speed * Time.deltaTime;
			//animator.StopPlayback ();
			UpdateState ("move_character_left_gun");
		} else if (Input.GetKey (KeyCode.RightArrow)) { // RIGHT
			if (collision) { // Si estamos en el borde del escenario, para moverse
				speed = 2.5f;
			}
			transform.position += Vector3.right * speed * Time.deltaTime;
			//animator.StopPlayback ();
			UpdateState ("move_character_right_gun");
		} else
			UpdateState("idle_gun_character");

		if (Input.GetKeyDown (KeyCode.UpArrow) && grounded) { // SALTO
			jump = true;
		}

		if (Input.GetKeyDown (KeyCode.Z)) {
			Vector3 position = transform.position;
			position.y -= 0.4f;
			position.x += 0.65f;
			Instantiate(bulletPrefab,position,Quaternion.identity);
		}
	}

	void FixedUpdate() {
		if (jump) {
			rb2d.AddForce (Vector2.up * jumpPower, ForceMode2D.Impulse);
			jump = false;
		}
	}

	public void UpdateState(string state = null) {
		if (state != null) {
			animator.Play(state); // Ejecutar la animación pasada como parámetro
		}
	}

	void OnTriggerEnter2D(Collider2D other) {
		Debug.Log ("Colisión con el límite del escenario");
		if (other.gameObject.tag == "brick") {
			collision = true;
			speed = 0;
		}
	}

	void OnCollisionStay2D(Collision2D other) {
		if (other.gameObject.tag == "ground") {
			grounded = true;
		}
	}

	void OnCollisionExit2D(Collision2D other) {
		if (other.gameObject.tag == "ground") {
			grounded = false;
		}
	}
		
}
