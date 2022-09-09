using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IModel
{
    void Init(int health);
    
    int Health { get; set; }
    int MaxHealth { get; set; }
    
    event Action HealthChanged;

    void OnCollidedWithBox();
}
