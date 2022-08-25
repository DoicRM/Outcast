using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
 
public class MainMenuButtonController : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private Text mainMenuPrompt;

    void Awake()
    {
        mainMenuPrompt = GameObject.Find("Prompt").GetComponent<Text>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        // Main menu
        if (name == "BtnNewGame")               { mainMenuPrompt.text = "Start a new game.";}
        else if (name == "BtnLoadGame")         { mainMenuPrompt.text = "Load a saved game."; }
        else if (name == "BtnOptions")          { mainMenuPrompt.text = "Change the settings."; }
        else if (name == "BtnQuitGame")         { mainMenuPrompt.text = "Exit to the desktop."; }
        // Options
        else if (name == "BtnLanguageChange")   { mainMenuPrompt.text = "Change the game language."; }
        else if (name == "BtnControlsSettings") { mainMenuPrompt.text = "Check the control settings."; }
        else if (name == "BtnBackToMenu")       { mainMenuPrompt.text = "Return to the main menu."; }
        else if (name == "BtnBackToOptions")    { mainMenuPrompt.text = "Return to the options."; }
        else                                    { mainMenuPrompt.text = ""; }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        mainMenuPrompt.text = "";
    }
}
