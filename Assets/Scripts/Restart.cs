using UnityEngine;
using System.Collections;

public class Restart : MonoBehaviour {
  
  void Start() {
  }
	public void OnClick() {
    Time.timeScale = 1;
    Application.LoadLevel("main");
  }
}
