using UnityEngine;
using System.Collections;
using TMPro;
using UnityEngine.SceneManagement;

// Makes objects float up & down while gently spinning.
public class followSubmarine : MonoBehaviour {

  public TextMeshPro score;
  public GameObject sub;
  public Camera camera;
  private int points;
  private float timer;
  public float speed;
  private bool teased = false;

  void Start(){
    points = 0;
  }

  void Update(){
    timer += Time.deltaTime;
    if (timer >= 0.3f && points <= 356){
      points++;
      score.text = "You won " + points + " points!";

      sub.transform.Translate(new Vector3(0f, -1.0f, 0f) * Time.deltaTime * speed);

    }
    if(points >= 356 && !teased){
      StartCoroutine(TeaseAf());
      teased = true;
    }
  }

  private IEnumerator TeaseAf(){
    yield return new WaitForSeconds(1);
    score.text = "Get 300 more...";
    StartCoroutine(showAf());
  }

  private IEnumerator showAf(){
    yield return new WaitForSeconds(2);
    score.text = "And reach Africa!";
    camera.orthographicSize = 90.0f;
    StartCoroutine(backToMenu());
  }

  private IEnumerator backToMenu(){
    yield return new WaitForSeconds(3);

  }
}
