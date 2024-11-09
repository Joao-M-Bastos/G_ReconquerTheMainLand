using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Character")]
public class CharacterData : ScriptableObject
{
    public string Name;
    public int MaxLife;
    public float Speed;
    public float Aceleration;
}
