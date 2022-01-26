using UnityEngine;
using UnityEngine.EventSystems;

public class RandomCell : MonoBehaviour, IPointerClickHandler
{    
    [SerializeField] private SpriteRenderer _spriteItem;      
    [SerializeField] private CellEffect _cellEffect;
    [SerializeField] private Particle _particle;

    private Item _item;
    private Answer _answer;
    
    public void CellData(Item item)
    {       
        _item = item;
       
    }

    public void Init()
    {
        _spriteItem.sprite = _item.Sprite;              
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if(_answer.CheckAnswer(_item))
        {
            
            _cellEffect.RightAnswer(_spriteItem);
            _particle.PlayExplosionFX(transform.position);
                      
        }
        else
        {           
            _cellEffect.WrongAnswer(_spriteItem);
        }     
        
    }

    private void Start()
    {
        _answer = FindObjectOfType<Answer>();
        _answer.Clear.AddListener(DestroyCell);

    }

    private void DestroyCell()
    {
        Destroy(gameObject,1f);
    }
}
