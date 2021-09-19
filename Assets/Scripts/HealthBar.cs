using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : SliderChanger
{
    [SerializeField] private Player _player;

    private void OnEnable()
    {
        _player.HealthChanged += SetProgress;
    }

    private void OnDisable()
    {
        _player.HealthChanged -= SetProgress;
    }
}
