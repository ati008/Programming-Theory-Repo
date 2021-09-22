using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
  // Start is called before the first frame update
  void Start()
  {
    var vehicle = GameManager.Instance.selectedVehicle;
    Instantiate(vehicle, transform.position, vehicle.transform.rotation);
  }

}
