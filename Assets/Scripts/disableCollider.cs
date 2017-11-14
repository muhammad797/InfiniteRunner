using UnityEngine;
using System.Collections;

public class disableCollider : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {
		Destroy(gameObject.GetComponent("BoxCollider2D"));
	}
}
