using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public static void LoadNextScene()
    {
        Debug.Log("Loading a new scene...");
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public static void StartNewGame()
    {
        Debug.Log("Starting a new game...");
        // TODO
    } 

    public static void LoadOptionsScene()
    {
        Debug.Log("Loading a options scene...");
        // TODO
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
