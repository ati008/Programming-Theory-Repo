using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  public GameObject vehiclePrefab;
  private Vehicle vehicleInstance;
  float horizontalInput;
  float forwardInput;
  // Start is called before the first frame update
  void Start()
  {
    vehicleInstance = Instantiate(vehiclePrefab).GetComponent<Vehicle>();
  }

  // Update is called once per frame
  void Update()
  {
    horizontalInput = Input.GetAxis("Horizontal");
    transform.Rotate(Vector3.up, vehicleInstance.turnSpeed * horizontalInput * Time.deltaTime);
    forwardInput = Input.GetAxis("Vertical");
    transform.Translate(Vector3.forward * Time.deltaTime * vehicleInstance.speed * forwardInput);
  }
}
