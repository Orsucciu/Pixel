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
  public AudioClip speech;
  AudioSource audioSource;
  bool audioIsPlayed = false;
  Vector3 startPos;
  Quaternion startRotation;

  public float degreesPerSecond = 15.0f;
  public float amplitude = 0.5f;
  public float frequency = 1f;
  Vector3 posOffset = new Vector3 ();
  Vector3 tempPos = new Vector3 ();

  public Transform target;

  void Start(){

    eyeL.SetActive(false);
    eyeR.SetActive(false);
    //pasquale.GetComponent<floater>().enabled = false;
    audioSource = GetComponent<AudioSource>();

    startPos = pasquale.transform.position;
    startRotation = pasquale.transform.rotation;

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
    posOffset = transform.position;
    //pasquale.transform.rotation = Quaternion.Euler(-90.0f, -196.3f, 21.4f);

    transform.LookAt(target);


    StartCoroutine(glowingEyes());
    StartCoroutine(resetPaoli());

    if(!hasMoved){
        floater();
    }

    if(!audioIsPlayed){
      audioIsPlayed = true;
      //audioSource.PlayOneShot(impact, 1f);
      audioSource.PlayOneShot(speech, 1f);

    }
  }

  private IEnumerator resetPaoli(){

    yield return new WaitForSeconds(audioSource.clip.length);
    pasquale.transform.position = startPos;
    pasquale.transform.rotation = startRotation;
    eyeL.SetActive(false);
    eyeR.SetActive(false);
    hasMoved = true;
  }

  private IEnumerator glowingEyes(){

    yield return new WaitForSeconds(1);
    eyeL.SetActive(true);
    eyeR.SetActive(true);
  }

  void floater(){
    transform.Rotate(new Vector3(0f, Time.deltaTime * degreesPerSecond, 0f), Space.World);

    // Float up/down with a Sin()
    tempPos = posOffset;
    tempPos.y += Mathf.Sin (Time.fixedTime * Mathf.PI * frequency) * amplitude;

    transform.position = tempPos;
  }
}
