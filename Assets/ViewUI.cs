using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ViewUI : MonoBehaviour, IView
{
    [SerializeField] private Button _button;
    [SerializeField] private Image _healthBar;

    void Start() {
        _button.onClick.AddListener(ButtonClick);
    }

    public void ButtonClick() {
        CollidedWithBox?.Invoke();
    }

    void IView.SetHealth(int health, int maxHealth) {
        _healthBar.fillAmount = (float)health / maxHealth;
    }

    public event Action CollidedWithBox;
}
