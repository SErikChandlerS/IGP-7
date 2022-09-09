using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Model : IModel
{
    public void Init(int health) {
        Health = health;
        MaxHealth = health;
    }

    public int Health { get; set; }
    public int MaxHealth { get; set; }

    public event Action HealthChanged;

    public void OnCollidedWithBox() {
        Health--;
        HealthChanged?.Invoke();
    }
}
