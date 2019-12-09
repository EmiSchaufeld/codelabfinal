using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AnswerTheMurder : MonoBehaviour
{
    public Button solveButton;
    public Text notebookWriting;
    public Image notebook;


    public Text guess;
    public InputField guessHere;
    public Button guessButton;
    public Text solveText;

    public GameObject player;

    public void TurnOffandOn()
    {

        //turn off notebook and stuff and turn on guess
        solveButton.gameObject.SetActive(false);
        notebookWriting.gameObject.SetActive(false);
        notebook.gameObject.SetActive(false);
        guess.gameObject.SetActive(true);
        guessHere.gameObject.SetActive(true);
        guessButton.gameObject.SetActive(true);

        //turn off player controller so they don't move while typing
        PlayerControl control = player.GetComponent<PlayerControl>();
        control.enabled = false;


        

          

    }
    public void Solve()
    {
        //if they guess right good end, if anything else bad end
        if (solveText.text == "Spencer" || solveText.text == "spencer")
        {
            SceneManager.LoadScene("Good End");
        }
        else
        {
            SceneManager.LoadScene("Bad End");
        }

    }
}
