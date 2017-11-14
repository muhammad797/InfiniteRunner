using UnityEngine;
using System.Collections;

public class ExitButton : MonoBehaviour {

    public void exitGame (bool exit)
        {
        if (exit == true)
            {
                Application.Quit();
            }
        }

}
