using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player : MonoBehaviour {
  public int pHP = 10;
  public static int Score = 0;
  public Text ScoreText;
  public Text pLifeText;
  public Text LastScoreText;
  private int pScore = 0;
  private Zombie _zombie;

	void Start () {
    ScoreText.text = "Score: 0";
    pLifeText.text = "Life: " + pHP.ToString();
	}

  void Update () {
    if (Input.GetMouseButtonDown(0)) {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit = new RaycastHit();

        if (Physics.Raycast(ray, out hit)){
            GameObject obj = hit.collider.gameObject;
            //Debug.Log(obj.name);
            try{
              _zombie = obj.GetComponent<Zombie>();
              _zombie.zDamage();
            }catch{}
        }
    }
    if (pHP <= 0) {
      Time.timeScale = 0;
      Canvas.SetActive("pLifeText", false);
      Canvas.SetActive("ScoreText", false);
      Canvas.SetActive("PauseButton", false);
      Canvas.SetActive("DeadImage", true);
      Canvas.SetActive("Quad", true);
      LastScoreText.text = "Your Score: " + pScore.ToString();
      Canvas.SetActive("LastScoreText", true);
      Canvas.SetActive("RestartButton", true);
      Canvas.SetActive("ExitToStartButton", true);
    }
  }

  public void pDamage(){
    //Debug.Log("Player Damaged");
    pHP--;
    pLifeText.text = "Life: " + pHP.ToString();
  }

  public void GetScore() {
    pScore += 100;
    ScoreText.text = "Score: " + pScore.ToString();
  }
}
