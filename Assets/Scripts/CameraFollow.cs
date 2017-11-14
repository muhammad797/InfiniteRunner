using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

    public GameObject player;
    private Transform _t;

	// Use this for initialization
	void Start () {
    _t = player.transform;
	}
	
	// Update is called once per frame
	void Update () {
			
        
             transform.position = new Vector3(_t.position.x + 6f, transform.position.y, transform.position.z);

	}
}
