using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Presenter : IDisposable
{
    private readonly IModel _model;
    private readonly IView _view;

    public Presenter(IView view, IModel model) {
        _model = model;
        _view = view;
        _model.HealthChanged += OnHealthChanged;
        _view.CollidedWithBox += OnCollidedWithBox;

        OnHealthChanged();
    }

    public void Dispose() {
        _model.HealthChanged -= OnHealthChanged;
        _view.CollidedWithBox -= OnCollidedWithBox;
    }

    private void OnCollidedWithBox() {
        _model.OnCollidedWithBox();
    }

    private void OnHealthChanged() {
        _view.SetHealth(_model.Health, _model.MaxHealth);
    }
}
