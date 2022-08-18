using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Misc", menuName = "Outcast/Item/Misc")]
public class Misc : Item
{
    void Reset()
    {
        type = ItemType.Misc;
    }
}
