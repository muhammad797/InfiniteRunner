using UnityEngine;
using System.Collections;

public class OnDeathTrigger : MonoBehaviour {

	CameraFollow cF;

	// Use this for initialization
	void Start () {
		cF = GetComponent<CameraFollow> ();
	}
	
	// Update is called once per frame
	void Update(){
		if (Player.alive == false) {
			cF.enabled = false;	
		} else if (Player.alive == true) {
			cF.enabled = true;		
		}

	}
}
