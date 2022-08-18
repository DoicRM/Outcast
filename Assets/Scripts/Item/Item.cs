using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    None,
    Weapon,
    Armor,
    Food,
    Quest,
    Written,
    Misc
}

public abstract class Item : ScriptableObject
{
    [Header("Generic Info")]
    public string itemName;
    [HideInInspector] public ItemType type;
    [TextArea]
    public string description;
    public float value;

    virtual public string PrintInfo()
    {
        return $"Name: {itemName}\nType: {type}\nDescription: {description}\nValue: {value}";
    }
}
