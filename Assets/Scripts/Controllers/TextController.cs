using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour
{
    public Text displayText;
    static string textToDisplay;

    public void PrintDialog(string text)
    {
        textToDisplay = text;
        StartCoroutine(Type());
    }

    public void Print(string text)
    {
        displayText.text = "";
        textToDisplay = text;
        StartCoroutine(Type());
    }

    IEnumerator Type()
    {
        foreach (char letter in textToDisplay.ToCharArray())
        {
            displayText.text += letter;
            yield return new WaitForSeconds(0.02f);
        }
    }

    public void PrintNarrative(string text)
    {
        displayText.text += "<color=grey>" + text + "</color>";
    }
}
