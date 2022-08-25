using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public static void LoadNextScene()
    {
        Debug.Log("Loading new scene");
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    // MAIN MENU
    public static void StartNewGame()
    {
        Debug.Log("Starting new game");
        LoadNextScene();
    } 

    public static void LoadGame()
    {
        Debug.Log("Loading load game view");
        // GameObject.Find("LoadGameCanvas").transform.Find("LoadGamePanel").gameObject.SetActive(true);
    }

    public static void LoadOptionsView()
    {
        Debug.Log("Loading options view");
        GameObject.Find("OptionsCanvas").transform.Find("OptionsPanel").gameObject.SetActive(true);
    }

    public static void LeaveOptionsView()
    {
        Debug.Log("Options view closed");
        GameObject.Find("OptionsCanvas").transform.Find("OptionsPanel").gameObject.SetActive(false);
    }

    public static void LoadControlsView()
    {
        Debug.Log("Loading controls view");
        GameObject.Find("OptionsCanvas").transform.Find("ControlsPanel").gameObject.SetActive(true);
    }

    public static void LeaveControlsView()
    {
        Debug.Log("Controlls view closed");
        GameObject.Find("OptionsCanvas").transform.Find("ControlsPanel").gameObject.SetActive(false);
    }

    public static void ChangeGameLanguage() // for now!
    {
        // Debug.Log("Game language changed");
        // GameObject.Find("OptionsCanvas").transform.Find("OptionsPanel").transform.Find("BtnLanguageChange").transform.Find("ControlsSettingsText").GetComponent<Text>().text = "Język: PL";
    }

    public static void QuitGame()
    {
        Debug.Log("Game closed");
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; // for testing purpose
        #endif
        Application.Quit();
    }
}
