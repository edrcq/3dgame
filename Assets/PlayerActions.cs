using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	static public void tryToRaycast (GameObject target) {
		RaycastHit hit;

		if (Physics.Raycast(target.transform.position, target.transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
		{
			Debug.DrawRay(target.transform.position, target.transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
			Debug.Log("Did Hit");
			Debug.Log("Hit distance : " + hit.distance + " collider : " + hit.collider + " rigidbody : " + hit.rigidbody);
			if (hit.collider.tag == "IronOre") {
				Debug.Log("WOO ! IRON ORE FOUND");
				GameObject found = hit.collider.gameObject;
				Destroy(found);
			}
		}
	}
}
