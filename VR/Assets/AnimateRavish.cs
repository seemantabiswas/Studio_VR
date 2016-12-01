using UnityEngine;
using System.Collections;

public class AnimateRavish : MonoBehaviour {

	public Animator anim;
	private bool handshake = false;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			handshake = !handshake;
		}
		anim.SetBool ("handShake", handshake);
		if (handshake) {
			anim.Play ("Handshake");
			handshake = false;
		}
	}

}
