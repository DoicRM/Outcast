using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Log
{
    NotStarted,
    Running,
    Success,
    Failed,
    Obsolete
}

[CreateAssetMenu(fileName = "Quest", menuName = "Outcast/Quest")]
public class Quest : ScriptableObject
{
    public string Name;
    [TextArea] public string description;
    public Log status;
    public bool isRunning;
    public bool isCompleted;

    public void Start()
    {
        isCompleted = false;
        isRunning = true;
        status = Log.Running;
        // Added a new quest to the journal: {Name}
    }

    public void End(Log status)
    {
        isRunning = false;
        isCompleted = true;
        this.status = status;
    }

    public string PrintInfo()
    {
        return $"Name: {name}\nDescription: {description}\nStatus: {status}";
    }
}
