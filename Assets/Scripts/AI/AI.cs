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
    public string aiName;
    public int level;
    public int[] attribute = new int[(int)Attribute.MaxMana + 1];
    [TextArea]
    public string description;
    public Guild guild;
    public Attitude attitude;
    public Weapon[] weapons = new Weapon[2];
    public Inventory inventory = new Inventory();

    public void AddItem(Item item)
    {
        inventory.AddItem(item);
    }

    public void AddItems(Item item, int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            inventory.AddItem(item);
        }
    }

    public void RemoveItem(Item item)
    {
        inventory.RemoveItem(item);
    }

    public void RemoveItems(Item item, int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            inventory.RemoveItem(item);
        }
    }

    public bool HasItem(Item item)
    {
        return inventory.HasItem(item);
    }

    public bool HasItems(Item item, int amount)
    {
        return inventory.HasItems(item, amount);
    }

    public void EquipItem(Weapon weapon)
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
                        return;
                    }
                    weapons[1] = weapon;
                }
            }

            // if (IsPlayer())
            // {
            //     // You're short of {weapon.CalcAttributeDifference(this)} to use a {weapon.Name}.
            // }
        }
    }

    public void ShowInventory()
    {
        inventory.Show();
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
}
