using UnityEngine;
using System.Collections;

public class NewGame1 : MonoBehaviour {

	public void OnClick() {
    gameObject.SetActive(false);
    Canvas.SetActive("PauseMenu_Cancel", false);
    Canvas.SetActive("PauseMenu_NewGame2", true);
  }
}
