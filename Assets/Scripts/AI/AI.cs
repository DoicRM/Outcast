using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum Attribute
{
    Strength,
    Dexterity,
    Life,
    MaxLife,
    Mana,
    MaxMana
}

public enum Guild
{
    None,
    SilentGuard,
    Whisperers,
    Outsiders,
    Explorers,
    Heretics,
    Monsters
}

public enum Attitude
{
    Neutral,
    Friendly,
    Angry,
    Hostile
}

public abstract class AI : ScriptableObject
{
    [Header("AI")]
    public string aiName;
    public int level;
    public int[] attribute = new int[(int)Attribute.MaxMana + 1];
    [TextArea] public string description;
    public Guild guild;
    public Attitude attitude;
    public Weapon[] weapons = new Weapon[2];
    // public Inventory inventory = new Inventory();
    public List<Item> inventory = new List<Item>();

    public void AddItem(Item item)
    {
        inventory.Add(item);
    }

    public void AddItems(Item item, int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            inventory.Add(item);
        }
    }

    public void RemoveItem(Item item)
    {
        inventory.Remove(item);
    }

    public void RemoveItems(Item item, int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            inventory.Remove(item);
        }
    }

    public bool HasItem(Item item)
    {
        return inventory.Contains(item);
    }

    public bool HasItems(Item item, int amount)
    {
        int ownedItems = 0;
        for (int i = 0; i < amount; i++)
        {
            if (inventory.Contains(item))
            {
                ownedItems++;
            }
        }

        return (ownedItems >= amount);
    }

    public string EquipItem(Weapon weapon)
    {
        if (HasItem(weapon))
        {
            if (weapon.IsMeetsWeaponRequirements(this))
            {
                if (weapons is not null)
                {
                    if (weapon.weaponType == WeaponType.OneHanded
                        || weapon.weaponType == WeaponType.TwoHanded)
                    {
                        weapons[0] = weapon;
                        return "";
                    }
                    weapons[1] = weapon;
                }
            }
            if (IsPlayer())
            {
                return $"You're short of {weapon.CalcAttributeDifference(this)} to use a {weapon.name}.";
            }
        }
        return "";
    }

    public string ShowInventory()
    {
        if (inventory.Count <= 0)
        {
            return "It's empty here.";
        }
        string str = "";
        foreach (var item in inventory)
        {
            str += item.name + " x1\n";
        }
        return str;
    }

    public void ClearInventory()
    {
        inventory.Clear();
    }

    public Color GetAttitudeColor()
    {
        if (attitude == Attitude.Hostile)
        {
            return Color.red;
        }
        else if (attitude == Attitude.Angry)
        {
            return Color.yellow;
        }
        else if (attitude == Attitude.Friendly)
        {
            return Color.green;
        }

        return Color.white;
    }

    public string PrintAttitude()
    {
        return $"{name} is {attitude.ToString().ToLower()} now.";
    }

    public bool IsPlayer()
    {
        Player hero = GameObject.Find("GameController").GetComponent<PlayerController>().player;
        return this == hero;
    }
}
