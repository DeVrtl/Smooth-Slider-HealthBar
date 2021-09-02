using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderChanger : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private float _speed;

    private Player _player;

    public void SetProgress(float progress)
    {
        _slider.maxValue = _player.MaxHealth;
        _slider.value = Mathf.MoveTowards(_slider.value, progress, _speed * Time.deltaTime);
    }
}
