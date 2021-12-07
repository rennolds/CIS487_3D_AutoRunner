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
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
  }

  public void LevelWon()
  {
    //player reached needed velocity
    Debug.Log("YOU WON");
  }
}
