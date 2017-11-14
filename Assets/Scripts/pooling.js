#pragma strict

var background : GameObject;

var coinOne : GameObject;
var coinTwo : GameObject;
var spikeOne : GameObject;
var spikeTwo : GameObject;

var randomSpawner : int;


function Start () {

}

function OnTriggerEnter2D (player : Collider2D) {
	
	
	// 16 cases for things to appear
		randomSpawner = Random.Range (0, 15);
		
		if (randomSpawner == 0){
			coinOne.SetActive(false);
			coinTwo.SetActive(false);
			spikeOne.SetActive(false);
			spikeTwo.SetActive(false);		
			
			Debug.Log("Case 0");
		} else if (randomSpawner == 1){
			coinOne.SetActive(true);
			coinTwo.SetActive(false);
			spikeOne.SetActive(false);
			spikeTwo.SetActive(false);		
			
			Debug.Log("Case 1");
		} else if (randomSpawner == 2){
			coinOne.SetActive(false);
			coinTwo.SetActive(true);
			spikeOne.SetActive(false);
			spikeTwo.SetActive(false);		
			
			Debug.Log("Case 2");	
		} else if (randomSpawner == 3){
			coinOne.SetActive(false);
			coinTwo.SetActive(false);
			spikeOne.SetActive(true);
			spikeTwo.SetActive(false);		
			
			Debug.Log("Case 3");		
		} else if (randomSpawner == 4){
			coinOne.SetActive(false);
			coinTwo.SetActive(false);
			spikeOne.SetActive(false);
			spikeTwo.SetActive(true);		
			
			Debug.Log("Case 4");			
		} else if (randomSpawner == 5){
			coinOne.SetActive(true);
			coinTwo.SetActive(true);
			spikeOne.SetActive(false);
			spikeTwo.SetActive(false);		
			
			Debug.Log("Case 5");			
		} else if (randomSpawner == 6){
			coinOne.SetActive(true);
			coinTwo.SetActive(false);
			spikeOne.SetActive(true);
			spikeTwo.SetActive(false);			
			
			Debug.Log("Case 6");
		} else if (randomSpawner == 7){
			coinOne.SetActive(true);
			coinTwo.SetActive(false);
			spikeOne.SetActive(false);
			spikeTwo.SetActive(true);		
			
			Debug.Log("Case 7");			
		} else if (randomSpawner == 8){
			coinOne.SetActive(false);
			coinTwo.SetActive(true);
			spikeOne.SetActive(true);
			spikeTwo.SetActive(false);			
			
			Debug.Log("Case 8");
		} else if (randomSpawner == 9){
			coinOne.SetActive(false);
			coinTwo.SetActive(true);
			spikeOne.SetActive(false);
			spikeTwo.SetActive(true);		
			
			Debug.Log("Case 9");
		} else if (randomSpawner == 10){
			coinOne.SetActive(false);
			coinTwo.SetActive(false);
			spikeOne.SetActive(true);
			spikeTwo.SetActive(true);		
			
			Debug.Log("Case 10");
		} else if (randomSpawner == 11){
			coinOne.SetActive(true);
			coinTwo.SetActive(true);
			spikeOne.SetActive(true);
			spikeTwo.SetActive(false);		
			
			Debug.Log("Case 11");
		} else if (randomSpawner == 12){
			coinOne.SetActive(true);
			coinTwo.SetActive(true);
			spikeOne.SetActive(false);
			spikeTwo.SetActive(true);		
			
			Debug.Log("Case 12");
		} else if (randomSpawner == 13){
			coinOne.SetActive(false);
			coinTwo.SetActive(true);
			spikeOne.SetActive(true);
			spikeTwo.SetActive(true);		
			
			Debug.Log("Case 13");			
		} else if (randomSpawner == 14){
			coinOne.SetActive(true);
			coinTwo.SetActive(false);
			spikeOne.SetActive(true);
			spikeTwo.SetActive(true);		
			
			Debug.Log("Case 14");
		} else if (randomSpawner == 15){
			coinOne.SetActive(true);
			coinTwo.SetActive(true);
			spikeOne.SetActive(true);
			spikeTwo.SetActive(true);		

			Debug.Log("Case 15");
		} else {
			Debug.LogError("their is some error in 'Game' check it");
		}
		

    background.transform.position.x = background.transform.position.x + (60);
    background.transform.position.y = 0;
}