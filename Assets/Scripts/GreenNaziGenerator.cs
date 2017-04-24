using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenNaziGenerator : MonoBehaviour {

	public GameObject greenNaziPrefab;
	public float generatorTime = 1f;
	public GameObject vegaNaziGunPrefab;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void CreateNazi() {
		Vector3 position = transform.position;
		position.x += Random.Range (-5f,0f);
		Instantiate(greenNaziPrefab,transform.position, Quaternion.identity);
	}

	public void StartGenerator() {
		InvokeRepeating ("CreateNazi",0f,generatorTime);
	}

	void CancelGenerator()
	{
		CancelInvoke ();
	}
	void GunShot(Vector3 position) {
		Instantiate(vegaNaziGunPrefab,position,Quaternion.identity);
	}
}
