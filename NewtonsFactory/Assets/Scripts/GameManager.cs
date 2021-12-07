using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
  public void LevelFailed()
  {
    //player died or failed to reach peak velocity
    Debug.Log("GAME OVER");
  }

  public void LevelWon()
  {
    //player reached needed velocity
    Debug.Log("YOU WON");
  }
}
