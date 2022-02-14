using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
   [SerializeField] private ItemData _itemData;
   [SerializeField] private Grid _grid;
   [SerializeField] private Answer _answer;
    private Queue<Item> _idItem;
    private int height;
    private int width;
       
    public void ItemData(ItemData itemdata)
    {
        _itemData = itemdata;        
    }
    
    public void LevelLoad(GridVector vector)
    {
        
        _grid.GridList(FindIdentifiers());
        width = vector.Width;
        height = vector.Height;
        _grid.GridData(width, height);
        Invoke("InitGrid", 1f);
    }

    private void Awake()
    {
        _idItem = FindIdentifiers();
    }

    private void InitGrid()
    {
        _grid.Init();
    }
 
    private Queue<Item> FindIdentifiers()
    {
        Queue<Item> idItem = new Queue<Item>();

        foreach (var item in _itemData.Item)
        {         
            idItem.Enqueue(item);
        }         
        return idItem;
    }

}
