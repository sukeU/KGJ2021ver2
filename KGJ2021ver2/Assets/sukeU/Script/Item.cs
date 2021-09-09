using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
[CreateAssetMenu(fileName = "Item", menuName = "CreateItem")]

public class Item : ScriptableObject
{
    public Sprite icon;
    public new string name;
    public int number;
}