	using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {

	public float speed = 0.05f;
	private bool walking = false;
	private Vector3 spawnPoint;

	// Use this for initialization
	void Start () {

		spawnPoint = transform.position;
	}

	void Update () {

		if (walking) {
			transform.position = transform.position + Camera.main.transform.forward * speed;

		}
		if (transform.position.y < -2.1f) {
			transform.position = spawnPoint;
		}
		Ray ray = Camera.main.ViewportPointToRay (new Vector3 (0.5f, 0.5f, 0.0f));

		RaycastHit hit;
		Debug.DrawRay (transform.position, transform.forward, Color.green);
		if (Physics.Raycast (ray, out hit)) {
			Debug.Log (hit.collider.name);

			if (hit.collider.name.Contains ("Plane")) {
				Debug.Log ("Plane");
				walking = true;

			} 
//				else if (hit.rigidbody.name.Contains ("Ravish")) {
//				if (hit.distance < 2.5F) {
//					walking = false;
//				} else {
//					walking = false;
//				}
//
//			}
				else {
				walking = false;
			}
		}
	}
		

}