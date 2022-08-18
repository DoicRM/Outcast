using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Gender
{
    Male,
    Female
}

[CreateAssetMenu(fileName = "Npc", menuName = "Outcast/AI/Npc")]
public class Npc : AI
{
    public int id;
    public Gender gender;
    public Armor armor;
    public float money;

    public void EquipItem(Armor armor)
    {
        if (HasItem(armor))
        {
            this.armor = armor;
        }
    }

    public bool IsPlayer()
    {
        // return this == Hero;
        return true;
    }

    public string PrintInfo()
    {
        return $"Name: {aiName}\nID: {id}\nLevel: {level}\nDescription: {description}\nGender: {gender.ToString()}\nAttitude: {attitude.ToString()}\nMoney: {money}";
    }
}
