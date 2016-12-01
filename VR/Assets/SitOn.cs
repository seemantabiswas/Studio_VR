 using UnityEngine;
using System.Collections;

public class SitOn : MonoBehaviour {

	public GameObject character;
	Animator anim;
	bool isWalkingTowards = false;
	private bool alreadySitted = false;


	// Use this for initialization
	void Start () {
		anim = character.GetComponent<Animator> ();
		if (!alreadySitted) {
			isWalkingTowards = true;
			anim.SetTrigger ("isWalking");
		}
	}
	
	// Update is called once per frame
	void Update () {

		if (isWalkingTowards) {
			Vector3 targetDir;
			targetDir = new Vector3 (transform.position.x - character.transform.position.x, 0f, transform.position.z - character.transform.position.z);
			Quaternion rot = Quaternion.LookRotation (targetDir);
			character.transform.rotation = Quaternion.Slerp (character.transform.rotation, rot, 0.03f);
			character.transform.Translate (Vector3.forward * 0.03f);
			Debug.Log (Vector3.Distance (character.transform.position, this.transform.position));
			if (Vector3.Distance (character.transform.position, this.transform.position) < 2.0f) {
				anim.SetTrigger ("isSitting");

				character.transform.rotation = this.transform.rotation;
				isWalkingTowards = false;
				alreadySitted = true;

			}
		}

		else if (alreadySitted) {
			anim.SetTrigger ("isTyping");

		}
	
	}


}

