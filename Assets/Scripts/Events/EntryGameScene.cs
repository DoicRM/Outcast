using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EntryGameScene : MonoBehaviour
{
    [HideInInspector] public TextController textController;
    [HideInInspector] public Text textDisplayer;

    // Use this for initalization
    private void Awake()
    {
        textController = GetComponent<TextController>();
        textDisplayer = textController.GetComponent<Text>();
    }

    private void Start()
    {
        StartCoroutine(WelcomeCoroutine());
    }

    IEnumerator WelcomeCoroutine()
    {
        textController.PrintText("");
        yield return new WaitForSeconds(2);
        textController.PrintText("Radosław 'Doic' Michalak presents a text game titled");
        yield return new WaitForSeconds(3);
        SceneLoader.LoadNextScene();
    }
}
