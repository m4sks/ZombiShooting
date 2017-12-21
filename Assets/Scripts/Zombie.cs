using UnityEngine;
using System.Collections;

public class Zombie : MonoBehaviour {
  public GameObject zombie;

  public int zHP;
  public float speed;
  private Vector3 pPos = new Vector3(0.0f, 0.0f, -7.0f);

  private GameObject cam;
  private Player pl;


  //private float angleY;
  //public Transform target;
  //public Transform goal;

	void Start () {
    //deltaTime += (int)System.Random()%30;
    cam = GameObject.Find("MainCamera");
    pl = cam.GetComponent<Player>();
	}

	void Update () {
    if (this.zHP <= 0) {
      Destroy(this.zombie);
      pl.GetScore();
    }
    if (Time.timeScale != 0) {
      transform.position = Vector3.MoveTowards(transform.position, pPos, speed);
    }
    Vector3 dist = this.transform.position - pPos;
    if (dist.sqrMagnitude <= 0.5f) {
      Destroy(this.zombie);
      pl.pDamage();
    }

    /*Vector3 targetDir = target.position - transform.position;
    Vector3 forward = transform.forward;
    angleY = Vector3.Angle(targetDir, forward);*/
    //angleY = transform.position.
    //transform.Rotate(0.0f, this.Angle, 0.0f);
	}

  public void zDamage() {
    this.zHP--;
  }

  /*void spawn() {
    if (pHP <= 0) {
      return;
    }else {
      Instantiate (zombie, new Vector3((float)Math.Pow(-1, Random()) * Random()%6, 0, 0), new Vector3(0, -180, 0));
    }
  }*/
}
