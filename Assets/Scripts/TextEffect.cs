using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class TextEffect : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private float _duration;
    
    public void FadeIn()
    {
        Fade(1f, _duration);
    }

    public void FadeOut()
    {
        Fade(0f, _duration);
    }

    private void Fade(float value,float duration)
    {
        _text.DOFade(value, duration);
    }
    
}
