using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Written", menuName = "Outcast/Item/Written")]
public class Written : Item
{
    void Reset()
    {
        type = ItemType.Written;
    }
}
