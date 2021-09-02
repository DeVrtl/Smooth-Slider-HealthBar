using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float _maxHealth = 100f;
    private float _templateNumber = 10;
    private float _currentHealth;

    public float MaxHealth => _maxHealth;

    public void TakeDamage()
    {
        _currentHealth -= _templateNumber;
        _maxHealth = _currentHealth;
    }

    public void Heal()
    {
        _currentHealth += _templateNumber;
        _maxHealth = _currentHealth;
    }
}
