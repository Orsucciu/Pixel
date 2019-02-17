using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Interaction script designed for the player camera

public class interact : MonoBehaviour {

	public Camera cam;
  private GameObject Missaghji;
	private GameObject canvasMissaghji;

	// Use this for initialization
	void Start () {
		canvasMissaghji = GameObject.FindGameObjectWithTag("canvasMissaghji");
		canvasMissaghji.GetComponent<Canvas>().enabled = false;
		Missaghji = GameObject.FindGameObjectWithTag("Missaghji");

	}

	// Update is called once per frame
	void Update () {
				canvasMissaghji.GetComponent<Canvas>().enabled = false;
        MostrarMensaje();
		if (Input.GetKeyDown (KeyCode.E)) {

			RaycastHit vista;

			if (Physics.Raycast (cam.transform.position, cam.transform.forward, out vista, 5)) {

        Debug.Log(vista.collider.gameObject.name);

				if(vista.collider.gameObject.name.Contains("door")){
					Interactable target = vista.transform.GetComponent<Interactable> ();
					if (target != null) {

						target.doSomething ();
					}

				}

				if(vista.collider.gameObject.name.Contains("monitor")){
					InteractableMonitor target = vista.transform.GetComponent<InteractableMonitor> ();
					if (target != null) {

						target.doSomething ();
					}

				}
		  }
	}
}

    void MostrarMensaje(){
        RaycastHit vista;

        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out vista, 5))
        {
            if (vista.collider.gameObject.name.Contains("door") || vista.collider.gameObject.name.Contains("monitor"))
            {
                canvasMissaghji.GetComponent<Canvas>().enabled = true;
                Missaghji.GetComponent<Text>().text = "Appoghju <E>";
						}
        }
    }
}
