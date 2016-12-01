using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LookAtMe : MonoBehaviour, IGvrGazeResponder {

	public bool move = false;
	public Transform target;

//	private float delay = 0.0f;

	private Rigidbody rBody;
	public void OnGazeEnter() {
//		Debug.Log ("Gazzed");
//		rBody = GetComponent<Rigidbody> ();
//		if (rBody.name == "Ravish") {
//			if (!move) {
//				move = !move;
//			}
//		
//		}
		Debug.Log (target.transform.rotation.y);


//		delay = Time.time + 2.0f;
		move = true;

			
	}
	public void OnGazeExit() {
//		if (Time.time > delay) {
//			SceneManager.LoadScene ("VideoScene");
//		}
//		GetComponent<Renderer> ().material.color = Color.white;
		move = !move;

	}
	public void OnGazeTrigger() {
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (move) {
			transform.LookAt(target);
		}

	}
}
