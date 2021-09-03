using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private UnityEvent _currentHealthEvent;

    private float _maxHealth = 100f;
    private float _templateNumber = 10;
    private float _currentHealth;

    public float CurrentHealth => _currentHealth;
    public float MaxHealth => _maxHealth;

    private void Start()
    {
        _currentHealthEvent.Invoke();
    }

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
