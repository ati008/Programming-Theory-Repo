using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
  public GameObject player;
  [SerializeField] Vector3 offset = new Vector3(30, 0, 10);
  Vector3 rotation = new Vector3(0, -90, 0);
  // Start is called before the first frame update
  void Start()
  {
    transform.Rotate(player.transform.rotation.eulerAngles+rotation);
  }

  // Update is called once per frame
  void LateUpdate()
  {
    transform.position = player.transform.position + offset;
  }
}
