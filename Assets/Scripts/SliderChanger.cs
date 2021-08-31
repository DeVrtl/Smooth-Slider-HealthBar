using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderChanger : MonoBehaviour
{
    [SerializeField] private Slider _slider;

    public void SetMaxProgress(float progress)
    {
        _slider.maxValue = progress;
        _slider.value = progress;
    }

    public void SetProgress(float progress)
    {
        _slider.value = progress;
    }

    public void HandleBar(float progress, float speed)
    {
        _slider.value = Mathf.MoveTowards(_slider.value, progress, speed * Time.deltaTime);
    }
}
