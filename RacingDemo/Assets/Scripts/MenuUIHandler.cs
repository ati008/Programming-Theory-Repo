using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuUIHandler : MonoBehaviour
{
  private void Start()
  {
    GameManager.Instance.selectedVehicleIndex = 1;
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
