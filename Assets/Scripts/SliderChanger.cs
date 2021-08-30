using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderChanger : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private float _speed;

    private float _currentProgress;

    private void Update()
    {
        HandleBar();
    }

    public void IncreaseSlider()
    {
        _currentProgress += 10;
        HandleBar();
    }

    public void DecreaseSlider()
    {
        _currentProgress -= 10;
        HandleBar();
    }

    public void HandleBar()
    {
        _slider.value = Mathf.MoveTowards(_slider.value, _currentProgress, _speed * Time.deltaTime);
    }
}
