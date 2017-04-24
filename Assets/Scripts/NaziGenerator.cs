using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaziGenerator : MonoBehaviour {

	public GameObject naziPrefab;
	public GameObject naziGunPrefab;
	public float generatorTime = 1f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void CreateNazi() {
		Vector3 position = transform.position;
		position.x += Random.Range (-5f,5f);
		Instantiate(naziPrefab,position, Quaternion.identity);
	}

	public void StartGenerator() {
		InvokeRepeating ("CreateNazi",0f,generatorTime);
	}

	void GunShot(Vector3 position) {
		Instantiate(naziGunPrefab,position,Quaternion.identity);
	}
}
