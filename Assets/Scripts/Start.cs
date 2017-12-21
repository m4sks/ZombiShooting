using UnityEngine;
using System.Collections;

public class Start : MonoBehaviour {
  public void Onclick() {
    Time.timeScale = 1;
    Application.LoadLevel("main");
  }
}
