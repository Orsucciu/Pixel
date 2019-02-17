using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.SceneManagement;

public class form2Handle : MonoBehaviour
{
  public GameObject reaction;
  public GameObject reactionParent;
  public Button reactionButton;

  void Start(){
    reactionButton.onClick.AddListener(TaskReaction);

  }

  void Update(){

  }

  void TaskReaction(){
    StartCoroutine(Example());
  }

  private IEnumerator Example()
  {
   yield return new WaitForSeconds(1);
   SceneManager.LoadScene(3);
  }
}
