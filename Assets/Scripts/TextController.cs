using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour
{
    public Text displayText;
    List<string> actionLog = new List<string>();

    public void PrintText(string text)
    {
        displayText.text = text;
    }

    public void PrintText(string text, Color color)
    {
        displayText.color = color;
        displayText.text = text;
    }

    public void PrintTextWithSave(string text)
    {
        DisplayText(text);
        DisplayLoggedText();
    }

    public void PrintTextWithSave(string text, Color color)
    {
        DisplayText(text);
        DisplayLoggedText(color);
    }
    
    public void DisplayLoggedText()
    {
        string logAsText = string.Join("\n", actionLog.ToArray());
        displayText.text = logAsText;
    }

    public void DisplayLoggedText(Color color)
    {
        string logAsText = string.Join("\n", actionLog.ToArray());
        displayText.color = color;
        displayText.text = logAsText;
    }

    public void DisplayText(string text)
    {
        string combinedText = text + "\n"; // roomNavigation.currentRoom.description
        LogStringWithReturn(combinedText);
    }

    public void DisplayText(string text, Color color)
    {
        string combinedText = text + "\n"; // roomNavigation.currentRoom.description
        LogStringWithReturn(combinedText);
    }

    public void LogStringWithReturn(string stringToAdd)
    {
        actionLog.Add(stringToAdd + "\n");
    }
}
