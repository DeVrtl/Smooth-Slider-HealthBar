using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private float _health;

    private float _templateNumber = 10;

    public event UnityAction<float> HealthChanged;

    public float Health => _health;

    private void Start()
    {
        HealthChanged?.Invoke(_health);
    }

    public void TakeDamage()
    {
        _health -= _templateNumber;
        HealthChanged?.Invoke(_health);
    }

    public void Heal()
    {
        _health += _templateNumber;
        HealthChanged?.Invoke(_health);
    }
}
