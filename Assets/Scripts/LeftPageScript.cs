using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LeftPageScript : MonoBehaviour {


    public Text text;
    public Button AButton;
    public Button BButton;

    public bool option1;
    public bool option2;

    private enum States
    {
        question, trueState, falseState
    }

    private States myState;



	// Use this for initialization
	void Start () {

        myState = States.question;
	}
	
	// Update is called once per frame
	void Update () {
        if (myState == States.question)
        {
            question();
        }
            else if (myState == States.trueState) {
                trueState ();
            }
            else if (myState == States.falseState)
            {
                falseState ();
            }
        }
		
	}


    void OnEnable()
    {
        AButton.onClick.AddListener(delegate{option1 = true;});
        BButton.onClick.AddListener(delegate {option2 = true;});
    }


    void question (){
        text.text = "Ice is cold.";

        if(option1 == true){myState = States.trueState} 
        else if (option2 == true){myState = States.falseState;}
    }

    void trueState(
    {
        text.text = "Correct!";
    }
    void falseState()
    {
        text.text = "Wrong..";
    }
}
