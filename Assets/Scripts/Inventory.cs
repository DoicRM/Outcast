using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private List<Item> items = new List<Item>();

    public void AddItem(Item item)
    {
        items.Add(item);
    }

    public void AddItems(Item item, int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            items.Add(item);
        }
    }

    public void RemoveItem(Item item)
    {
        if (!HasItem(item))
        {
            return;
        }

        items.Remove(item);
    }

    public void RemoveItems(Item item, int amount)
    {
        if (!HasItems(item, amount))
        {
            return;
        }

        for (int i = 0; i < amount; i++)
        {
            items.Remove(item);
        }
    }

    public void Clear()
    {
        items.Clear();
    }

    public bool HasItem(Item item)
    {
        return items.Contains(item);
    }

    public bool HasItems(Item item, int amount)
    {
        int ownedItems = 0;
        for (int i = 0; i < amount; i++)
        {
            if (items.Contains(item))
            {
                ownedItems++;
            }
        }

        return (ownedItems >= amount);
    }

    public string Show()
    {
        // if (items.Count <= 0)
        // {
        //     return "It's empty here.";
        // }
        // string str = "";
        // foreach (var item in items)
        // {
        //     str += item.PrintInfo() + "\n";
        // }
        // return str;
        if (items.Count <= 0)
        {
            return "It's empty here.";
        }
        string str = "";
        foreach (var item in items)
        {
            str += item.name + "\n";
        }
        return str;
    }
}
