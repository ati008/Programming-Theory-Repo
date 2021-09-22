using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
  float horizontalInput;
  float forwardInput;
  float speedField = 20.0f;
  float turnSpeedField = 45.0f;

  //Encapsulation
  [SerializeField]
  public virtual float speed
  {
    get
    {
      return speedField;
    }
    set
    {
      if (value > 0)
        speedField = value;

    }
  }
  //Encapsulation
  [SerializeField]
  public virtual float turnSpeed
  {
    get
    {
      return turnSpeedField;
    }
    set
    {
      if (value > 0)
        turnSpeedField = value;

    }
  }

  private void LateUpdate()
  {
    Turn();
    Move();
  }
  //Abstraction
  protected virtual void Turn()
  {
    horizontalInput = Input.GetAxis("Horizontal");
    transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
  }
  //Abstraction
  protected virtual void Move()
  {
    forwardInput = Input.GetAxis("Vertical");
    transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
  }

}
