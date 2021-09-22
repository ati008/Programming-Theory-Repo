using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class VehiclePicker : MonoBehaviour
{
  public Vehicle[] AvailableVehicles;
  public Button VehicleButtonPrefab;

  public Vehicle SelectedVehicle { get; private set; }
  public System.Action<Vehicle> onSelectionChanged;

  List<Button> m_VehicleButtons = new List<Button>();

  // Start is called before the first frame update
  public void Start()
  {
    foreach (var vehicle in AvailableVehicles)
    {
      var newButton = Instantiate(VehicleButtonPrefab, transform);
      newButton.GetComponentInChildren<Text>().text = vehicle.name;

      newButton.onClick.AddListener(() =>
      {
        SelectedVehicle = vehicle;
        foreach (var button in m_VehicleButtons)
        {
          button.interactable = true;
        }

        newButton.interactable = false;

        onSelectionChanged.Invoke(SelectedVehicle);
      });

      m_VehicleButtons.Add(newButton);
    }
    if (GameManager.Instance.selectedVehicle == null)
      SelectVehicle(AvailableVehicles[0]);
    else
      SelectVehicle(GameManager.Instance.selectedVehicle);
  }

  public void SelectVehicle(Vehicle vehicle)
  {
    for (int i = 0; i < AvailableVehicles.Length; ++i)
    {
      if (AvailableVehicles[i] == vehicle)
      {
        m_VehicleButtons[i].onClick.Invoke();
      }
    }
  }
}
