using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;
 
public class MainMenuButtonController : MonoBehaviour, IPointerEnterHandler
{
    private Text mainMenuPrompt;

    void Awake()
    {
        mainMenuPrompt = GameObject.Find("Prompt").GetComponent<Text>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (name == "BtnNewGame")       { mainMenuPrompt.text = "Start a new game.";}
        else if (name == "BtnOptions")  { mainMenuPrompt.text = "Change the settings."; }
        else if (name == "BtnQuitGame")  { mainMenuPrompt.text = "Exit to the desktop."; }
        else { mainMenuPrompt.text = ""; }
    }
}
