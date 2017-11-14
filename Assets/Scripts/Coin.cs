using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Coin : MonoBehaviour {


	// Use this for initialization
	void Start () {
	}


	void OnTriggerEnter2D (Collider2D col)
	{
			if (col.gameObject.tag == "coins") {
				collectables.coins++;
				col.gameObject.SetActive(false);
			}
	} 

}
