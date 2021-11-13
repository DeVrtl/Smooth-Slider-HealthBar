using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private float _health;
    [SerializeField] private float _maxHealth;
    [SerializeField] private float _minHealth;

    private float _templateNumber = 10;

    public event UnityAction<float> HealthChanged;

    public float MaxHealth => _maxHealth;

    private void Start()
    {
        HealthChanged?.Invoke(_health);
        _health = _maxHealth;
    }

    public void TakeDamage()
    {
        if (_health > _minHealth)
        {
            _health -= _templateNumber;
            HealthChanged?.Invoke(_health);
        }
    }

    public void Heal()
    {
        if (_health < _maxHealth)
        {
            _health += _templateNumber;
            HealthChanged?.Invoke(_health);
        }
    }
}
