using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class PanelEffect : MonoBehaviour
{
    [SerializeField] private Image _image;
    [SerializeField] private float _duration;

    public void FadeIn()
    {
        Fade(1f, _duration);
    }
    public void FadeOut()
    {
        Fade(0f, _duration);
    }
    private void Fade(float value, float duration)
    {
        _image.DOFade(value, duration);
    }

}
