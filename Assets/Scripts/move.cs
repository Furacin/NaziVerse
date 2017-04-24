using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum Direccion {Izquierda, Derecha};

public class move : MonoBehaviour {

	private string name_scene;

	public GameObject bulletPrefab;

	public float speed = 2.5f;
	private Animator animator;
	public float jumpPower = 2.5f;
	private bool jump;
	bool grounded = false;
	bool collision_init = false;
	bool collision_fin = false;

	public Direccion direccion = Direccion.Derecha;

	private Rigidbody2D rb2d;

	private AudioSource audioPlayer;
	public AudioClip shotClip;
	public AudioClip jumpClip;
	public AudioClip walkClip;

	// Use this for initialization
	void Start () {
		Scene scene = SceneManager.GetActiveScene();
		name_scene = scene.name;

		audioPlayer = GetComponent<AudioSource> ();
		animator = GetComponent<Animator> (); // Obtenemos la componente animator del objeto
		rb2d = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {

		animator.SetBool("Grounded",grounded);
		if (Input.GetKey (KeyCode.DownArrow)) { // DUCK
			UpdateState ("duck");
		} else if (Input.GetKey (KeyCode.LeftArrow)) { // LEFT
			//InvokeRepeating ("PlayWalk",0.01f,1f);
			if (collision_fin) {
				//speed = 2.5f;
				//collision_init = false;
			}
			direccion = Direccion.Izquierda;
			transform.position += Vector3.left * speed * Time.deltaTime;
			UpdateState ("move_character_left_gun");
		} else if (Input.GetKey (KeyCode.RightArrow)) { // RIGHT
			//InvokeRepeating ("PlayWalk",0.01f,1f);
			if (collision_init) {
				speed = 2.5f;
				collision_init = false;
			}
			direccion = Direccion.Derecha;
			transform.position += Vector3.right * speed * Time.deltaTime;
			UpdateState ("move_character_right_gun");
		} else
			UpdateState("idle_gun_character");


		if (Input.GetKeyDown (KeyCode.UpArrow) && grounded) { // JUMP
			audioPlayer.clip = jumpClip;
			audioPlayer.Play();
			jump = true;
		}

		if (Input.GetKeyDown (KeyCode.Space)) { // SHOT
			if (name_scene != "fin_level1") {
				audioPlayer.clip = shotClip;
				audioPlayer.Play ();
				Vector3 position = transform.position;
				position.y -= 0.4f;
				position.x += 0.65f;
				Instantiate (bulletPrefab, position, Quaternion.identity);
			}
		}

		/*if (Input.GetKeyUp (KeyCode.RightArrow)) {
			audioPlayer.Stop ();
		}

		if (Input.GetKeyUp (KeyCode.LeftArrow)) {
			audioPlayer.Stop ();
		}*/

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
			collision_init = true;
			speed = 0;
		}
		// End of street
		if (other.gameObject.tag == "brick2") {
			//collision_fin = true;
			//speed = 0;
			Final_Scene();
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

	void Final_Scene() {
		SceneManager.LoadScene ("fin_level1");
	}

	/*void PlayWalk() {
		audioPlayer.clip = walkClip;
		audioPlayer.Play();
	}*/
		
}
