using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private Slider _slider;
    [SerializeField] private float _speed;

    private void OnEnable()
    {
        _player.HealthChanged += OnHealthChanged;
    }

    private void OnDisable()
    {
        _player.HealthChanged -= OnHealthChanged;
    }

    private void Start()
    {
        _slider.maxValue = _player.MaxHealth;
    }

    private void OnHealthChanged(float health)
    {
        _slider.value = Mathf.MoveTowards(_slider.value, health, _speed * Time.deltaTime);
    }
}
