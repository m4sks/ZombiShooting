using UnityEngine;
using System.Collections;

public class ExitToStart : MonoBehaviour {
  public void OnClick() {
    Application.LoadLevel("start");
  }
}
