using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum WeaponType
{
    OneHanded,
    TwoHanded,
    Ranged
}

public enum DamageType
{
    Edge,
    Blunt,
    Point,
    Fire,
    Magic
}

[CreateAssetMenu( fileName = "Weapon", menuName = "Outcast/Item/Weapon" )]
public class Weapon : Item
{
    [Header("Weapon Info")]
    public WeaponType weaponType;
    public DamageType damageType;
    public int damage;
    public int[] requirement = new int[(int)Attribute.Dexterity + 1];

    public string CalcAttributeDifference(AI ai)
    {
        int difference;
        string strength = Attribute.Strength.ToString().ToLower();
        string dexterity = Attribute.Dexterity.ToString().ToLower();

        if (requirement[(int)Attribute.Strength] > ai.attribute[(int)Attribute.Strength])
        {
            difference = requirement[(int)Attribute.Strength] - ai.attribute[(int)Attribute.Strength];

            if (difference > 1)
            {
                return $"{difference} points of {strength}";
            }

            return $"{difference} point of {strength}";
        }

        difference = requirement[(int)Attribute.Dexterity] - ai.attribute[(int)Attribute.Dexterity];

        if (difference > 1)
        {
            return $"{difference} points of {dexterity}";
        }

        return $"{difference} point of {dexterity}";
    }

    public bool IsMeetsWeaponRequirements(AI ai)
    {
        return ((requirement[(int)Attribute.Strength] < ai.attribute[(int)Attribute.Strength] && requirement[(int)Attribute.Strength] > 0)
            || (requirement[(int)Attribute.Dexterity] < ai.attribute[(int)Attribute.Dexterity] && requirement[(int)Attribute.Dexterity] > 0));
    }

    public override string PrintInfo()
    {
        string weaponTypeStr = weaponType.ToString();
        string itemTypeStr = type.ToString();

        if (weaponType == WeaponType.OneHanded || weaponType == WeaponType.TwoHanded)
        {
            var firstHalf = weaponTypeStr.Substring(0, 3);
            var secondHalf = weaponTypeStr.Substring(3, weaponTypeStr.Length - 3);
            weaponTypeStr = firstHalf + "-" + secondHalf.ToLower();
        }

        string str = $"Name: {name}\nType: {weaponTypeStr} {itemTypeStr}\nDescription: {description}\nDamage: {damage}";

        if (requirement[(int)Attribute.Strength] == 0)
        {
            return str += $"\nRequired {Attribute.Dexterity.ToString().ToLower()}: {requirement[(int)Attribute.Dexterity]}\nValue: {value}";
        }

        return str += $"\nRequired {Attribute.Strength.ToString().ToLower()}: {requirement[(int)Attribute.Strength]}\nValue: {value}";
    }

    void Reset()
    {
        type = ItemType.Weapon;
    }
}
