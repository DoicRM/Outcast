using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlunderController : MonoBehaviour
{
    static private bool isPlunderModeEnabled = false;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public static void OpenClosePlunderView()
    {
        if (!isPlunderModeEnabled)
        {
            Debug.Log("Plunder mode enabled");
            isPlunderModeEnabled = true;
            Time.timeScale = 0;
            GameObject.Find("Canvas").transform.Find("PlunderPanel").gameObject.SetActive(true);
            return;
        }

        Debug.Log("Plunder mode disabled");
        isPlunderModeEnabled = false;
        Time.timeScale = 1;
        GameObject.Find("Canvas").transform.Find("PlunderPanel").gameObject.SetActive(false);
    }
}
