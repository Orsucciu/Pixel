using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour {
	private bool stateOpen = false;
	private bool opening = false;
	AudioSource audioSource;
	public AudioClip speech;
	public GameObject door;

	// Use this for initialization
	void Start () {
			audioSource = GetComponent<AudioSource>();
	}

	// Update is called once per frame
	void Update () {
		//broken. should open smoothly but dosn·t
		if (stateOpen == true && opening == true) {
			for (float i = 0f; i < 50f; i += 0.1f) {
				door.transform.Translate (0, i, 0);
			}

			opening = false;
		}

		if (stateOpen == false && opening == true) {
			for (float i = 0f; i > -50f; i -= 0.1f) {
				door.transform.Translate (0, i, 0);
			}
		}

	}

	public void doSomething(){
		Debug.Log ("HI, Im David");

	audioSource.PlayOneShot(speech, 1f);

		if (stateOpen == false) {
			stateOpen = true;
			opening = true;

		} else {
			stateOpen = false;
			opening = true;
		}
	}
}
