using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
  public GameObject[] Vehicles;
  // Start is called before the first frame update
  void Start()
  {
    var vehicle = Vehicles[GameManager.Instance.selectedVehicleIndex];
    Instantiate(vehicle, transform.position, vehicle.transform.rotation);
  }

}
