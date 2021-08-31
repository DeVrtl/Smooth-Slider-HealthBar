using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderChanger : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private float _speed;

    public void SetMaxProgress(float progress)
    {
        _slider.maxValue = progress;
        _slider.value = progress;
    }

    public void SetProgress(float progress)
    {
        _slider.value = Mathf.MoveTowards(_slider.value, progress, _speed * Time.deltaTime);
    }
}
