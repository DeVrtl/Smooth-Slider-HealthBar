using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class SliderChanger : MonoBehaviour
{
    [SerializeField] protected Slider _slider;
    [SerializeField] private float _speed;

    public void SetProgress(float value, float maxValue)
    {
        _slider.value = Mathf.MoveTowards(_slider.value, maxValue / value, _speed * Time.deltaTime);
    }
}
