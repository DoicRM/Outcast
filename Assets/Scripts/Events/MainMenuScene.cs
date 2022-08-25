using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuScene : MonoBehaviour
{
    void Awake()
    {
        GameObject.Find("OptionsCanvas").transform.Find("OptionsPanel").gameObject.SetActive(false);
        GameObject.Find("OptionsCanvas").transform.Find("ControlsPanel").gameObject.SetActive(false);
        GameObject.Find("Prompt").GetComponent<Text>().text = "";
    }

    void Start()
    {
        Debug.Log("Loading main menu scene...");
    }
}
