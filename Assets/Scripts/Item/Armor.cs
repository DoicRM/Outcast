using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Protection
{
    Edge,
    Blunt,
    Point,
    Fire,
    Magic
}

[CreateAssetMenu(fileName = "Armor", menuName = "Outcast/Item/Armor")]
public class Armor : Item
{
    [Header("Armor Info")]
    public int[] protection = new int[(int)Protection.Magic + 1];

    public override string PrintInfo()
    {
        string str = $"Name: {itemName}\nType: {type}\nDescription: {description}\n";

        for (Protection type = Protection.Edge; type <= Protection.Magic; type++)
        {
            str += $"{type} protection: {protection[(int)type]}\n";
        }

        str += $"Value: {value}";
        return str;
    }

    void Reset()
    {
        type = ItemType.Armor;
    }
}
