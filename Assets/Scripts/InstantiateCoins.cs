using UnityEngine;
using System.Collections;

public class InstantiateCoins : MonoBehaviour {

	// coin gameObject
	public GameObject coin;

	public static bool doInstan = false;

	void Update () {
		if (doInstan == true) {
			for (int i = 0; i < 2; i++ ){
				Instantiate (coin, new Vector2(this.transform.position.x, this.transform.position.y), this.transform.rotation);
			}
		}

	}

	void coinInstant ()
	{

	}
}
