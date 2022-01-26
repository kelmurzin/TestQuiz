using System;
using UnityEngine;

[Serializable]
public class GridVector 
{
    [SerializeField] private int _width;

    [SerializeField] private int _height;
    [SerializeField] private ItemData _itemData;

    public ItemData ItemData => _itemData;

    public int Width => _width;

    public int Height => _height;
}
