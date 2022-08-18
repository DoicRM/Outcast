using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuScene : MonoBehaviour
{
    [HideInInspector] public MenuNavigation menuNavigation;
    [HideInInspector] public TextController textController;
    [HideInInspector] public Text textDisplayer;

    void Awake()
    {
        textController = GetComponent<TextController>();
        textDisplayer = textController.GetComponent<Text>();
        menuNavigation = GetComponent<MenuNavigation>();
    }

    void Start()
    {
        Debug.Log("Loading main menu scene...");
    }
}
