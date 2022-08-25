using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameScene : MonoBehaviour
{
    [HideInInspector] public TextController textController;
    [HideInInspector] public Text textDisplayer;
    [SerializeField] private TextAsset inkJSON;

    private void Awake()
    {
        textController = GetComponent<TextController>();
        textDisplayer = textController.GetComponent<Text>();
        textController.displayText.text = "";
        GameObject.Find("Canvas").transform.Find("InventoryPanel").gameObject.SetActive(false);
        GameObject.Find("Canvas").transform.Find("PlunderPanel").gameObject.SetActive(false);
    }

    void Start()
    {
        StoryManager.GetInstance().EnterCutsceneMode(inkJSON);
    }

    void Update()
    {
        
    }
}
