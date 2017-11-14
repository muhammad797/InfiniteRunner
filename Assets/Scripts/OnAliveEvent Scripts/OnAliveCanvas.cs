using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OnAliveCanvas : MonoBehaviour {
	
	Canvas canvas;

	// Use this for initialization
	void Start () {
		canvas = GetComponent<Canvas>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Player.alive == true) {
			canvas.enabled = true;		 
		} else if (Player.alive == false) {
			canvas.enabled = false;				
		}
		

	}
}
