using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using Ink.Runtime;

public class StoryManager : MonoBehaviour
{
    private static StoryManager instance;
    public Text textDisplayer;
    [SerializeField] private GameObject[] choices;
    private Text[] choicesText;
    private Story currentStory;
    private bool isCutscenePlaying;
    private const string WAIT_TAG = "wait";
    private const string COLOR_TAG = "color";
    private const string PLUNDER_TAG = "plunder";

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Found more than one Story Manager in the scene");
        }
        instance = this;
    }

    public static StoryManager GetInstance()
    {
        return instance;
    }

    void Start()
    {
        isCutscenePlaying = true;

        choicesText = new Text[choices.Length];
        int index = 0;
        foreach (GameObject choice in choices)
        {
            choicesText[index] = choice.GetComponentInChildren<Text>();
            index++;
        }
    }

    void Update()
    {
        if (!isCutscenePlaying)
        {
            return;
        }

        if ((currentStory.currentChoices.Count == 0)
        && Input.GetKeyDown(KeyCode.Space))
        {
            ContinueStory();
        }
    }

    public void EnterCutsceneMode(TextAsset inkJSON)
    {
        currentStory = new Story(inkJSON.text);
        isCutscenePlaying = true;
        ContinueStory();
    }

    private void ExitCutscene()
    {
        isCutscenePlaying = false;
        textDisplayer.text = "";
    }

    private void ContinueStory()
    {
        if (currentStory.canContinue)
        {
            HandleTags(currentStory.currentTags);
            textDisplayer.text = currentStory.Continue();
            DisplayChoices();
            HandleTags(currentStory.currentTags);
        }
        else {
            ExitCutscene();
        }
    }

    public static Color ToColor(string color)
    {
        return (Color)typeof(Color).GetProperty(color.ToLowerInvariant()).GetValue(null, null);
    }

    private void HandleTags(List<string> currentTags)
    {
        foreach(string tag in currentTags)
        {
            string[] splitTag = tag.Split(':');
            if (splitTag.Length != 2)
            {
                Debug.LogError("Tag could not be appropriately parsed: " + tag);
            }
            string tagKey = splitTag[0].Trim();
            string tagValue = splitTag[1].Trim();

            switch (tagKey)
            {
                case WAIT_TAG:
                    int sec = int.Parse(tagValue);
                    StartCoroutine(Wait(sec));
                    break;
                case COLOR_TAG:
                    textDisplayer.color = ToColor(tagValue);
                    break;
                case PLUNDER_TAG:
                    Debug.Log("Plunder: " + tagValue);
                    PlunderController.OpenClosePlunderView();
                    break;
                default:
                    Debug.LogWarning("Tag came in but is not currently handled: " + tag);
                    break;
            }
        }
    }

    public IEnumerator Wait(int sec)
    {
        Debug.Log("Wait for " + sec.ToString() + " sec");
        yield return new WaitForSeconds(sec);
    }

    private void DisplayChoices()
    {
        List<Choice> currentChoices = currentStory.currentChoices;

        if (currentChoices.Count > choices.Length)
        {
            Debug.LogError($"Error: Story Manager not support {currentChoices.Count} choices, only {choices.Length}");
        }

        int index = 0;
        
        foreach(Choice choice in currentChoices)
        {
            choices[index].gameObject.SetActive(true);
            choicesText[index].text = choice.text;
            index++;
        }

        for (int i = index; i < choices.Length; i++)
        {
            choices[i].gameObject.SetActive(false);
        }
    }

    public void MakeChoice(int choiceIndex)
    {
        currentStory.ChooseChoiceIndex(choiceIndex);
        EventSystem.current.SetSelectedGameObject(null);
        ContinueStory();
    }
}
