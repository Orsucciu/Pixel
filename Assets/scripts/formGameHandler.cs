// To use this example, attach this script to an empty GameObject.
// Create three buttons (Create>UI>Button). Next, select your
// empty GameObject in the Hierarchy and click and drag each of your
// Buttons from the Hierarchy to the Your First Button, Your Second Button
// and Your Third Button fields in the Inspector.
// Click each Button in Play Mode to output their message to the console.
// Note that click means press down and then release.

using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.SceneManagement;

public class formGameHandler : MonoBehaviour
{
    //Make sure to attach these Buttons in the Inspector
    public Button go_Button;
    public InputField inputField;
    public Text answerText;
    public GameObject inputGroup;
    public GameObject answerTextParent;

    public Button go_Button2;
    public InputField inputField2;
    public Text answerText2;
    public GameObject inputGroup2;
    public GameObject answerTextParent2;

    public Button go_Button3;
    public InputField inputField3;
    public Text answerText3;
    public GameObject inputGroup3;
    public GameObject answerTextParent3;

    public Button go_Button4;
    public InputField inputField4;
    public Text answerText4;
    public GameObject inputGroup4;
    public GameObject answerTextParent4;

    public Button go_Button5;
    public InputField inputField5;
    public Text answerText5;
    public GameObject inputGroup5;
    public GameObject answerTextParent5;

    public GameObject response;
    public GameObject response1;
    public GameObject response2;
    public GameObject response3;

    public GameObject couple1;
    public GameObject couple2;
    public GameObject couple3;

    public GameObject reaction;
    public GameObject reactionParent;
    public Button reactionButton;

     public float targetTime = 60.0f;

    public List<fiure> fiuri = new List<fiure>();
    public List<Sprite> sprites = new List<Sprite>();

    void Start()
    {
        //Calls the TaskOnClick/TaskWithParameters/ButtonClicked method when you click the Button
        go_Button.onClick.AddListener(TaskGoButton);
        answerTextParent.SetActive(false);

        go_Button2.onClick.AddListener(TaskGoButton2);
        answerTextParent2.SetActive(false);

        go_Button3.onClick.AddListener(TaskGoButton3);
        answerTextParent3.SetActive(false);

        go_Button4.onClick.AddListener(TaskGoButton4);
        answerTextParent4.SetActive(false);

        go_Button5.onClick.AddListener(TaskGoButton5);
        answerTextParent5.SetActive(false);

        reactionButton.onClick.AddListener(TaskReaction);

        fiure pic = new fiure();
        pic.image = sprites[0];

        fiuri.Add(pic);
    }

    void Update(){

      targetTime -= Time.deltaTime;

      if (targetTime <= 0.0f)
      {
         timerEnded();
      }

    }

    void timerEnded()
    {
       Debug.Log("game over");
    }

    void TaskGoButton()
    {
        //Output this to console when Button1 or Button3 is clicked
        Debug.Log("You have clicked the button!");
        answerText.text = inputField.text;
        inputGroup.SetActive(false);
        answerTextParent.SetActive(true);
        response.SetActive(true);
        answerTextParent2.SetActive(true);
        couple1.SetActive(true);
    }

    void TaskGoButton2(){
      Debug.Log("You have clicked the button!");
      answerText2.text = inputField2.text;
      inputGroup2.SetActive(false);
      answerTextParent2.SetActive(true);
      response1.SetActive(true);
      answerTextParent3.SetActive(true);
      couple2.SetActive(true);
    }

    void TaskGoButton3(){
      Debug.Log("You have clicked the button!");
      answerText3.text = inputField3.text;
      inputGroup3.SetActive(false);
      answerTextParent3.SetActive(true);
      response2.SetActive(true);
      answerTextParent4.SetActive(true);
      reactionParent.SetActive(true);
      //couple3.SetActive(true);
    }

    void TaskGoButton4(){
      Debug.Log("You have clicked the button!");
      answerText4.text = inputField4.text;
      inputGroup4.SetActive(false);
      answerTextParent4.SetActive(true);
    }

    void TaskGoButton5(){
      Debug.Log("You have clicked the button!");
      answerText5.text = inputField5.text;
      inputGroup5.SetActive(false);
      answerTextParent5.SetActive(true);
    }

    void TaskReaction(){
      reaction.SetActive(true);
      reactionParent.SetActive(false);
      StartCoroutine(Example());
   }

   private IEnumerator Example()
   {
       yield return new WaitForSeconds(1);
       SceneManager.LoadScene(3);
   }

}
