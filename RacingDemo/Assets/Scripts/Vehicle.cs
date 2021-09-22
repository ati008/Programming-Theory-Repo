using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
  public virtual float speed { get; private set; } = 20.0f;
  public virtual float turnSpeed { get; private set; } = 45.0f;
  float horizontalInput;
  float forwardInput;

  private void LateUpdate()
  {
    Turn();
    Move();
  }
  public void Turn()
  {
    horizontalInput = Input.GetAxis("Horizontal");
    transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
  }
  public void Move()
  {
    forwardInput = Input.GetAxis("Vertical");
    transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
  }

}
