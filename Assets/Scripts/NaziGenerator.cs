using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaziGenerator : MonoBehaviour {

	public GameObject naziPrefab;
	public float generatorTime = 0.2f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void CreateNazi() {
		Instantiate(naziPrefab,transform.position, Quaternion.identity);
	}

	public void StartGenerator() {
		InvokeRepeating ("CreateNazi",0f,generatorTime);
	}
}
