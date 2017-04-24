using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenNaziController : MonoBehaviour {

	public GameObject naziGunPrefab;

	public float velocity = 2f;

	private Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {
		rb2d = gameObject.GetComponent<Rigidbody2D> ();
		rb2d.velocity = Vector2.left * velocity;
		CreateShot ();
		//InvokeRepeating("CreateShot",0.01f,Random.Range(0.5f,3f)); // Repetir la cadencia de disparos en un tiempo aleatorio (0.5s y 3s)
	}

	// Update is called once per frame
	void Update () {

	}

	void CreateShot() {
		Vector3 position = transform.position;
		position.y += 1.11f;
		position.x += -0.5f;
		Instantiate(naziGunPrefab,position,Quaternion.identity);
		//
	}
}
