using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ImageClose : MonoBehaviour {

	void OnMouseDown() {
		SceneManager.LoadScene ("Studio");
	}
}
