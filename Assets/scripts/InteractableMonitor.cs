using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InteractableMonitor : MonoBehaviour {

	public GameObject monitor;
  public int sceneNum;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		//broken. should open smoothly but dosn·t
	}

	public void doSomething(){
		Debug.Log ("HI, Im David");
    SceneManager.LoadScene(sceneNum);
	}
}
