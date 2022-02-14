using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class NextLevel : MonoBehaviour
{   
    [SerializeField] private Level _levelLoad;
    [SerializeField] private GameObject _restartButton;    
    [SerializeField] private GridData _gridData;     
    [SerializeField] private UnityEvent LevelDone = new UnityEvent();
    [SerializeField] private UnityEvent LevelRestart = new UnityEvent();

    private Queue<GridVector> _gridVector;

    public void RestartSet()
    {
        Invoke("RestartLevel", .5f);
        _restartButton.SetActive(false);
    }

    private void Awake()
    {
        _gridVector = FindVector();
        
    }

    private void Start()
    {
        LoadNextLevel();

    }
    
    private void RestartLevel()
    {
        _gridVector = FindVector();
        LoadNextLevel();
        LevelRestart?.Invoke(); 
       
    }

    private Queue<GridVector> FindVector()
    {
        Queue<GridVector> vector = new Queue<GridVector>();

        foreach (var grid in _gridData.GridVector)
        {
            vector.Enqueue(grid);
        }
        return vector;
    }
   
    private void LoadNextLevel()
    {
     
        if (_gridVector.Count == 0)
        {            
            _restartButton.SetActive(true);
            LevelDone?.Invoke();
        }
        else
        {            
            var gridVector = _gridVector.Dequeue();
            _levelLoad.LevelLoad(gridVector);
            _levelLoad.ItemData(gridVector.ItemData);
        }
     
    }

}
