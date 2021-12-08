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
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

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

        if (speed >= 45f)
        {
          FindObjectOfType<GameManager>().LevelWon();
        }
    }

    void OnTriggerEnter(Collider other)
    {
      if (other.CompareTag("Boost"))
      {
        forwardForce += 80f;
        sidewaysForce += 2f;
      }

      if (other.CompareTag("Debuff"))
      {
        forwardForce -= 60f;
        sidewaysForce -= 1.5f;
      }

      if (other.CompareTag("End"))
      {
        if (speed < 45f)
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
