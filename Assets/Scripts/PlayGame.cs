using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayGame : MonoBehaviour {

    public void playGame (int level)
    {
		Player.alive = true;        
        SceneManager.LoadScene(level);
    }
}
