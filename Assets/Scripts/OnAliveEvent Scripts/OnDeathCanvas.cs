using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OnDeathCanvas : MonoBehaviour {

	Image image;
	Canvas canvas;

	// Use this for initialization
	void Start () {
		canvas = GetComponent<Canvas>();
		image = GetComponent<Image> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Player.alive) {
			canvas.enabled = false;		 
		} else if (!Player.alive) {
			canvas.enabled = true;				
		}
		

	}
}
