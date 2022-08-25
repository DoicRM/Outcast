using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Menu", menuName = "Outcast/Menu")]
public class Menu : ScriptableObject
{
    public int choice;
    public string prompt;
    public string[] options;

    [HideInInspector] public TextController textController;
    [HideInInspector] public Text textDisplayer;

    public void ShowOptions()
    {
        if (options is not null)
        {
            for (int i = 0; i < options.Length; i++)
            {
                string currentOption = options[i];
                int index = i + 1;

                if (i == choice)
                {
                    textController.displayText.text = currentOption;
                    // textDisplayer.color = Color.white;
                }
                else
                {
                    textController.displayText.text = currentOption;
                    // textDisplayer.color = Color.grey;
                }

                // textController.PrintTextWithSave("[" + index.ToString() + "] " + currentOption);
                // textController.PrintTextWithSave(currentOption);
            }
        }
    }

    public void Init()
    {
        do
        {
            ShowOptions();

            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                choice--;
                if (choice == -1)
                {
                    choice = options.Length - 1;
                }
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                choice++;
                if (choice == options.Length)
                {
                    choice = 0;
                }
            }

        } while (!Input.GetKeyDown(KeyCode.Return));
    }

    // Start is called before the first frame update
    public void Start()
    {
        ShowOptions();
    }

    // Update is called once per frame
    void Update()
    {
        Init();
    }
}
