using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EntryGameScene : MonoBehaviour
{
    [HideInInspector] public TextController textController;
    [HideInInspector] public Text textDisplayer;

    private void Awake()
    {
        textController = GetComponent<TextController>();
        textDisplayer = textController.GetComponent<Text>();
        textController.displayText.text = "";
    }

    private void Start()
    {
        StartCoroutine(WelcomeCoroutine());
    }

    IEnumerator WelcomeCoroutine()
    {
        yield return new WaitForSeconds(2f);
        textController.displayText.text = "Radosław 'Doic' Michalak presents a text game titled";
        yield return new WaitForSeconds(3f);
        SceneLoader.LoadNextScene();
    }
}
