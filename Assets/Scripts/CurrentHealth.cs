using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrentHealth : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    private Player _player;

    public void CurrentHealthEvent()
    {
        _slider.value = _player.CurrentHealth;
    }
}
