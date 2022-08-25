using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    static private bool isMenuOpened = false;
    static private bool isInventoryOpened = false;

    void Update()
    {
        OpenCloseMenu();
        OpenCloseInventory();
    }

    static public void OpenCloseMenu()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!isMenuOpened)
            {
                Debug.Log("Menu opened");
                isMenuOpened = true;
                Time.timeScale = 0;
                return;
            }

            Debug.Log("Menu closed");
            isMenuOpened = false;
            Time.timeScale = 1;
        }
    }

    static public void OpenCloseInventory()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (!isInventoryOpened)
            {
                Debug.Log("Inventory opened");
                isInventoryOpened = true;
                Time.timeScale = 0;
                GameObject.Find("Canvas").transform.Find("InventoryPanel").gameObject.SetActive(true);
                return;
            }

            Debug.Log("Inventory closed");
            isInventoryOpened = false;
            Time.timeScale = 1;
            GameObject.Find("Canvas").transform.Find("InventoryPanel").gameObject.SetActive(false);
        }
    }
}
