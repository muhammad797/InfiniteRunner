using UnityEngine;
using System.Collections;

public class randomActive : MonoBehaviour {

	private int rR;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		rR = Random.Range (0, 1);


		if (rR == 1) {
			gameObject.SetActive (true);
			Debug.Log("rR is : 1");
		} else {  
			gameObject.SetActive(false);		
			Debug.Log("rR is : 0");
		}
	}
}
