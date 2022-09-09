using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IView
{
    void SetHealth(int health, int maxHealth);

    event Action CollidedWithBox;
}
