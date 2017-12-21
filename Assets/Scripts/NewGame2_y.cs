using UnityEngine;
using System.Collections;

public class NewGame2_y : MonoBehaviour {

  void Start() {
  }

  public void OnClick() {
    Time.timeScale = 1;
    Application.LoadLevel("main");

  }
}
