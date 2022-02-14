using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{     
    [SerializeField] private GameObject _cell;         
    [SerializeField] private Answer _answer;

    private Queue<Item> _idItem;
    private List<Item> _itemList = new List<Item>();
    private int _width;
    private int _height;

    public void GridList(Queue<Item> idItem)
    {
        _idItem = idItem;
    }

    public void GridData( int width,int height)
    {
        _width = width;
        _height = height;               
    }
        
    public void Init()
    {
        for (int x = -3; x < _width; x += 3)
        {
            for (int y = -3; y < _height; y += 3)
            {
                GameObject cell = Instantiate(_cell, new Vector2(x, y), Quaternion.identity);
                RandomCell randomCell = cell.GetComponent<RandomCell>();

                var idItem = _idItem.Dequeue();               
                _itemList.Add(idItem);
                randomCell.CellData(idItem);
                randomCell.Init();

            }

        }
        
        var idAnswer = Random.Range(0, _itemList.Count);
        Item id = _itemList[idAnswer];        
        _answer.SetIdentifier(id);
        
    }

    private void Start()
    {
        _answer.Clear.AddListener(NextLVL);
    }

    private void NextLVL()
    {
        _itemList.Clear();
    }
}

