using UnityEngine;
using System.Collections;

public class PauseCancel : MonoBehaviour {

  void Start() {
  }

  public void OnClick() {
    gameObject.SetActive(false);
    Canvas.SetActive("PauseMenu_NewGame1", false);
    Canvas.SetActive("Quad", false);
    Canvas.SetActive("PauseButton", true);
    Time.timeScale = 1;
  }
}
