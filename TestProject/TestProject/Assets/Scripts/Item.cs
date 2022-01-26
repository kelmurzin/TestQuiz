using System;
using UnityEngine;

[Serializable]
public class Item 
{
    [SerializeField] private string _identifiers;

    [SerializeField] private Sprite _sprite;

    public string Identifiers => _identifiers;
    public Sprite Sprite => _sprite;
}
