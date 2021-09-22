using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuUIHandler : MonoBehaviour
{
  private VehiclePicker picker;
  private void Start()
  {
    picker = GameObject.FindObjectOfType<VehiclePicker>();
    picker.onSelectionChanged += (v) => GameManager.Instance.selectedVehicle = v;
  }
  public void StartNew()
  {
    SceneManager.LoadScene(1);
  }

  public void Exit()
  {
#if UNITY_EDITOR
    EditorApplication.ExitPlaymode();
#else
    Application.Quit(); // original code to quit Unity player
#endif
  }
}
