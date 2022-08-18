using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Food", menuName = "Outcast/Item/Food")]
public class Food : Item
{
    [Header("Food Info")]
    public int[] bonus = new int[(int)Attribute.MaxMana + 1];

    public override string PrintInfo()
    {
        string str = $"Name: {name}\nType: {type}\nDescription: {description}";

        if (bonus[(int)Attribute.Life] == 0)
        {
            return str += $"\n{Attribute.Mana} bonus: {bonus[(int)Attribute.Mana]}\nValue: {value}";
        }
        else if (bonus[(int)Attribute.Mana] == 0)
        {
            return str += $"\n{Attribute.Life} bonus: {bonus[(int)Attribute.Life]}\nValue: {value}";
        }

        return str += $"\n{Attribute.Life} bonus: {bonus[(int)Attribute.Life]}\n{Attribute.Mana} bonus: {bonus[(int)Attribute.Mana]}\nValue: {value}";
    }

    void Reset()
    {
        type = ItemType.Food;
    }
}
