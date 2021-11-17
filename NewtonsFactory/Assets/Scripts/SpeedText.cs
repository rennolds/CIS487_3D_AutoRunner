using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedText : MonoBehaviour
{
    private GameObject player;
    PlayerMovement playerMovementScript;
    public Text speedText;

    void Start()
    {
      player = GameObject.FindGameObjectWithTag("Player");
      playerMovementScript = player.GetComponent<PlayerMovement>();
    }
    // Update is called once per frame
    void Update()
    {
        speedText.text = "Current: " + (playerMovementScript.speed).ToString("0") + " kh/m";
    }
}
