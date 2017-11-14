using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class collectables : MonoBehaviour {

	public GameObject player;
	Text text;
	public static int coins;

	// Use this for initialization
	void Start () {
		text = GetComponent<Text> ();
		coins = 0;
	}
	
	void Update ()
	{
		text.text = " " + coins;
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "Player") {
			Destroy(gameObject);		
		}

	} 
}
