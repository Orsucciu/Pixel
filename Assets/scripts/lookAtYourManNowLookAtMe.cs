using UnityEngine;
using System.Collections;

// Makes objects float up & down while gently spinning.
public class lookAtYourManNowLookAtMe : MonoBehaviour {

  public GameObject pasquale;
  public GameObject player;
  public GameObject eyeL;
  public GameObject eyeR;

  private bool hasMoved = false;

  public AudioClip impact;
  AudioSource audioSource;
  bool audioIsPlayed = false;
  bool blink = true;

  void Start(){

    eyeL.SetActive(false);
    eyeR.SetActive(false);
    pasquale.GetComponent<floater>().enabled = false;
    audioSource = GetComponent<AudioSource>();

  }

  void Update(){
    if(((player.transform.position - pasquale.transform.position).sqrMagnitude)<51 && hasMoved==false){
      //Debug.Log((player.transform.position - pasquale.transform.position).sqrMagnitude);
      playAnim();

      Debug.Log("Pao x,y,z:" + pasquale.transform.rotation.x + " ," + pasquale.transform.rotation.y + " ," + pasquale.transform.rotation.z + "Pla x,y,z:" + player.transform.rotation.x + " ," + player.transform.rotation.y + " ," + player.transform.rotation.z);

    }
  }

  void playAnim(){

    pasquale.transform.position = new Vector3(0.05f, 3.0f, 13.22f);
    pasquale.transform.rotation = Quaternion.Euler(-90.0f, -196.3f, 21.4f);

    StartCoroutine(glowingEyes());

    if(!audioIsPlayed){
      audioIsPlayed = true;
      audioSource.PlayOneShot(impact, 1f);

    }
  }

  private IEnumerator glowingEyes(){

    yield return new WaitForSeconds(1);
    eyeL.SetActive(true);
    eyeR.SetActive(true);
  }
}
