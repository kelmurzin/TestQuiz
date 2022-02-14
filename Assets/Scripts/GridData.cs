using UnityEngine;

[CreateAssetMenu(fileName = "New GridData", menuName = "GridData")]
public class GridData : ScriptableObject
{
    [SerializeField] private GridVector[] _gridVector;
   
    public GridVector[] GridVector => _gridVector;
    
}
