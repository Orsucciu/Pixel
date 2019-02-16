// To use this example, attach this script to an empty GameObject.
// Create three buttons (Create>UI>Button). Next, select your
// empty GameObject in the Hierarchy and click and drag each of your
// Buttons from the Hierarchy to the Your First Button, Your Second Button
// and Your Third Button fields in the Inspector.
// Click each Button in Play Mode to output their message to the console.
// Note that click means press down and then release.

using UnityEngine;
using UnityEngine.UI;

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

    }

    void TaskGoButton()
    {
        //Output this to console when Button1 or Button3 is clicked
        Debug.Log("You have clicked the button!");
        string answer = inputField.text;
        answerText.text = answer;
        inputGroup.SetActive(false);
        answerTextParent.SetActive(true);
    }

    void TaskGoButton2(){
      Debug.Log("You have clicked the button!");
      string answer2 = inputField2.text;
      answerText2.text = answer2;
      inputGroup2.SetActive(false);
      answerTextParent2.SetActive(true);
    }

    void TaskGoButton3(){
      Debug.Log("You have clicked the button!");
      string answer3 = inputField3.text;
      answerText3.text = answer3;
      inputGroup3.SetActive(false);
      answerTextParent3.SetActive(true);
    }

    void TaskGoButton4(){
      Debug.Log("You have clicked the button!");
      string answer4 = inputField4.text;
      answerText4.text = answer4;
      inputGroup4.SetActive(false);
      answerTextParent4.SetActive(true);
    }

    void TaskGoButton5(){
      Debug.Log("You have clicked the button!");
      string answer5 = inputField5.text;
      answerText5.text = answer5;
      inputGroup5.SetActive(false);
      answerTextParent5.SetActive(true);
    }

}
