using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	Text text;
	public static int score;

	// Use this for initialization
	void Start () {
		score = 0;
		text = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		text.text = "Score: " + score;
	}
}
