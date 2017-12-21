using UnityEngine;
using System.Collections;

public class NewGame2_n : MonoBehaviour {
  public void OnClick() {
    Canvas.SetActive("PauseMenu_NewGame2", false);
    Canvas.SetActive("PauseMenu_NewGame1", true);
    Canvas.SetActive("PauseMenu_Cancel", true);
  }
}
