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


    void Start()
    {
        //Calls the TaskOnClick/TaskWithParameters/ButtonClicked method when you click the Button
        go_Button.onClick.AddListener(TaskGoButton);
       // answerText.SetActive(false);

    }

    void TaskGoButton()
    {
        //Output this to console when Button1 or Button3 is clicked
        Debug.Log("You have clicked the button!");
//string answer = inputField.text;
        //answerText.text = answer;
       // inputGroup.SetActive(false);
        //answerText.SetActive(true);
    }

}
