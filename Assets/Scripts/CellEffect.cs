using UnityEngine;
using DG.Tweening;

public class CellEffect : MonoBehaviour
{
    [SerializeField] private float _scaleStart = 1f;
    [SerializeField] private float _scaleTime = 0.5f;
    [SerializeField] private float _scaleExit = 0f;
    [SerializeField] private SpriteRenderer _sprite;

    private void Start()
    {
        _sprite.transform.DOScale(_scaleStart, _scaleTime);        
    }
    
    public void RightAnswer(SpriteRenderer sprite)
    {
        sprite.transform.DOScale(_scaleExit, _scaleTime);
    }

    public void WrongAnswer(SpriteRenderer sprite)
    {
        sprite.transform.DOShakePosition
            (1f, strength: new Vector3(0.4f,0, 0), vibrato: 10, randomness: 1, snapping: false, fadeOut: true);
    }

}
