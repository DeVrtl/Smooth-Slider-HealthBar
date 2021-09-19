using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    private float _maxHealth;
    private float _templateNumber = 10;
    private float _currentHealth;

    public event UnityAction<float ,float> HealthChanged;

    public void TakeDamage()
    {
        _currentHealth -= _templateNumber;
        _maxHealth = _currentHealth;
        HealthChanged?.Invoke(_maxHealth, _currentHealth);
    }

    public void Heal()
    {
        _currentHealth += _templateNumber;
        _maxHealth = _currentHealth;
        HealthChanged?.Invoke(_maxHealth, _currentHealth);
    }
}
