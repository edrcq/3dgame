using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitMap : MonoBehaviour {

	public Transform IronOrePrefab;
	
	// Use this for initialization
	void Start () {
		GenerateIronOreField();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void GenerateIronOreField () {
		int max = 25;
		int i = 0;
		Vector3[] positions = new Vector3[25];
		for(i = 0; i < max; i++) {
			positions[i] = new Vector3(Random.Range(-10.0f, 10.0f), 1.29f, Random.Range(-10.0f, 10.0f));
		}

		foreach(Vector3 pos in positions) {
			Debug.Log(pos.y * 100);
			Instantiate(IronOrePrefab, pos, Quaternion.identity);
		}
		//positions[0] = new Vector3(5, 1.29, -5);

	}
}
