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
    }

    void OnTriggerEnter(Collider other)
    {
      if (other.CompareTag("Boost"))
      {
        forwardForce += 200f;
        sidewaysForce += 10f;
      }

      if (other.CompareTag("Debuff"))
      {
        forwardForce -= 100f;
        sidewaysForce -= 5f;
      }
    }

    public float getSpeed()
    {
      return forwardForce;
    }
}
