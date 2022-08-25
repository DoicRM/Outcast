using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Journal : MonoBehaviour
{
    private List<Quest> quests = new List<Quest>();

    public void Add(Quest quest)
    {
        quests.Add(quest);
        quest.Start();
    }

    public void End(Quest quest, Log status)
    {
        if (!quest.isCompleted)
        {
            quest.End(status);
        }
    }

    public string Show()
    {
        string str = "";
        if (quests.Count > 0)
        {
            str += "...........................................................................\n";
            foreach (var quest in quests)
            {
                str += quest.PrintInfo() + "\n";
                str += "...........................................................................";
            }
        }
        return str;
    }

    public void Clear()
    {
        quests.Clear();
    }
}
