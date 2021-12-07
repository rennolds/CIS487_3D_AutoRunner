using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce;
    public float sidewaysForce;
    public Vector3 velocity;
    public float speed;
    // Start is called before the first frame update
    void Update()
    {
      velocity = rb.velocity;
      speed = velocity.magnitude;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        //Add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); // adds a force of 2000 on the z-axis

        if (Input.GetKey("d"))
        {
          rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
          rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("right"))
        {
          rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("left"))
        {
          rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.transform.position.y <= 10)
        {
          FindObjectOfType<GameManager>().LevelFailed();
        }

        if (speed >= 50f)
        {
          FindObjectOfType<GameManager>().LevelWon();
        }
    }

    void OnTriggerEnter(Collider other)
    {
      if (other.CompareTag("Boost"))
      {
        forwardForce += 120f;
        sidewaysForce += 2.25f;
      }

      if (other.CompareTag("Debuff"))
      {
        forwardForce -= 75f;
        sidewaysForce -= 1.5f;
      }

      if (other.CompareTag("End"))
      {
        if (speed < 50f)
        {
          FindObjectOfType<GameManager>().LevelFailed();
        }
      }
    }

    public float getSpeed()
    {
      return forwardForce;
    }
}
