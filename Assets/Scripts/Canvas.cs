using UnityEngine;
using System.Collections;

public class Canvas : MonoBehaviour {
  static Canvas _canvas;

  void Start() {
    _canvas = GetComponent<Canvas>();
  }

  public static void SetActive(string name, bool b) {
    foreach(Transform child in _canvas.transform) {
      if(child.name == name) {
        child.gameObject.SetActive(b);
        return;
      }
    }
    Debug.LogWarning("Not found objname:"+name);
  }
}
