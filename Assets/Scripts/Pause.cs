using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {
  void Start() {}
  void Update() {}
	public void OnClick() {
    Time.timeScale = 0;
    gameObject.SetActive(false);
    Canvas.SetActive("PauseMenu_NewGame1", true);
    Canvas.SetActive("PauseMenu_Cancel", true);
    Canvas.SetActive("Quad", true);
  }
}
