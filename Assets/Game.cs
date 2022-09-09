using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class Game : MonoBehaviour
{
    [Inject] private IView _view;
    [Inject] private IModel _model;
    [SerializeField] private int _initialHealth = 10;
    private Presenter _presenter;

    private void Start() {
        Debug.Log(_model);
        _model.Init(_initialHealth);
        _presenter = new Presenter(_view, _model);
    }

    private void OnDestroy() {
        _presenter.Dispose();
    }
}
