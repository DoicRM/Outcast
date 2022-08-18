using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum MonsterType
{
    Passive,
    Hunter,
    Packhunter
}

[CreateAssetMenu(fileName = "Monster", menuName = "Outcast/AI/Monster")]
public class Monster : AI
{
    public MonsterType type;

    void Reset()
    {
        guild = Guild.Monsters;
    }
}
