using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SimonSaysManager : MonoBehaviour
{
    public List<SimonSaysObject> allButtons;
    private List<Button> simonButtonsPressed;
    private List<Button> playerButtonsPressed;
    private int numberOfPresses = 4;


    public void Start()
    {
        StartRound();
    }
    // Update is called once per frame
    public void StartRound()
    {
        StartCoroutine(PressButtons());
    }

    IEnumerator PressButtons()
    {
        //Find the canvas, and disable input to the canvas
        Canvas canvas = FindObjectOfType<Canvas>();
        canvas.GetComponent<GraphicRaycaster>().enabled = false;
        for (int i=0; i < allButtons.Count; i++)
        {
            allButtons[i].button.enabled = false;
        }

        for (int i = 0; i < numberOfPresses; i++)
        {
            int randomButton = Random.Range(0, allButtons.Count - 1);
            allButtons[randomButton].SelectButton();
            simonButtonsPressed.Add(allButtons[randomButton].button);
            yield return new WaitForSeconds(1f);
            allButtons[randomButton].DeselectButton();
            yield return new WaitForSeconds(1f);
            Debug.Log("Pressed Buttons: "+ i +" times");
        }

        for (int i = 0; i < allButtons.Count; i++)
        {
            allButtons[i].button.enabled = true;
        }
        canvas.GetComponent<GraphicRaycaster>().enabled = true;
    }
}
