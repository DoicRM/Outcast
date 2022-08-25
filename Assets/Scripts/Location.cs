using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Location", menuName = "Outcast/Location")]
public class Location : ScriptableObject
{
    public string locationName;
    public Guild occupation;
    [HideInInspector] public bool isVisited;
}
