using UnityEngine;
using System.Collections;

public class SpawnEnemy : MonoBehaviour {
  public GameObject zombie;
  public int deltaTime;
  private int timer;

	void Start () {
    timer = deltaTime + Random.Range(deltaTime/100, deltaTime);
	}
	void Update () {
    if (Time.timeScale != 0) {
	     timer--;
    }
    if (timer <= 0) {
      Spawn();
    }
	}

  void Spawn() {
    Vector3 pos = new Vector3(Random.Range(-6, 6), 0.0f, 0.0f);
    Quaternion rot = new Quaternion(0,180,0,1);
    Instantiate(zombie, pos, rot);
    timer = Random.Range(5, deltaTime);
  }
}
