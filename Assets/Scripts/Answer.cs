using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Answer : MonoBehaviour
{
    public UnityEvent Clear = new UnityEvent();

    [SerializeField] private Text _text;    
    [SerializeField] private UnityEvent TextFade = new UnityEvent();

    private Item _item;
   
    public void SetIdentifier(Item item)
    {
        _item = item;
        _text.text = "Find " + _item.Identifiers;
        TextFade?.Invoke();        
    }
    
    public bool CheckAnswer(Item item)
    {
        if(item == _item )
        {            
            Clear?.Invoke();                        
        }

        return item == _item;
    }   
}