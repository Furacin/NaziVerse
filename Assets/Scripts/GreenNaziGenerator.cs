using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenNaziGenerator : MonoBehaviour {

	public GameObject greenNaziPrefab;
	public float generatorTime = 0.5f;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void CreateNazi() {
		Instantiate(greenNaziPrefab,transform.position, Quaternion.identity);
	}

	public void StartGenerator() {
		InvokeRepeating ("CreateNazi",0f,generatorTime);
	}
}
