using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _maxHealth = 100f;
    [SerializeField] private SliderChanger _slider;

    private float _currentHealth;
    private float _templateNumber = 10;

    private void Start()
    {
        _currentHealth = _maxHealth;
        _slider.SetMaxProgress(_maxHealth);
    }

    private void Update()
    {
        _slider.SetProgress(_currentHealth);
    }

    public void TakeDamage()
    {
        _currentHealth -= _templateNumber;

        SettingProgress(_currentHealth);
    }

    public void AddHealth()
    {
        _currentHealth += _templateNumber;

        SettingProgress(_currentHealth);
    }

    private void SettingProgress(float number)
    {
        _slider.SetProgress(number);
    }
}
