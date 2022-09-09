using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ViewPhysics : MonoBehaviour, IView
{
    [SerializeField] private TMP_Text _healthText;

    public void OnCollisionEnter(Collision collision) {
        if (!collision.transform.TryGetComponent(out BoxTag _)) return;
        CollidedWithBox?.Invoke();
    }

    void IView.SetHealth(int health, int maxHealth) {
        _healthText.text = health.ToString();
    }

    public event Action CollidedWithBox;
}
