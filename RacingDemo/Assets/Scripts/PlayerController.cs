using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  [SerializeField] float speed = 20.0f;
  [SerializeField] float turnSpeed=45.0f;
  float horizontalInput;
  float forwardInput;
  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    horizontalInput = Input.GetAxis("Horizontal");
    forwardInput = Input.GetAxis("Vertical");
    // Move the vehicle forward
    transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
    transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
  }
}
