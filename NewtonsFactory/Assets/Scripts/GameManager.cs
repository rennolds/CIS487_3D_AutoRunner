using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void LevelFailed()
    {
        //player died or failed to reach peak velocity
        Debug.Log("GAME OVER");
        FindObjectOfType<FailureScreen>().FailScreen();
    }

    public void LevelWon()
    {
        //player reached needed velocity
        Debug.Log("YOU WON");
        FindObjectOfType<SuccessScreen>().WinScreen();
    }

}
