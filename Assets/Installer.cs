using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class Installer : MonoInstaller<Installer>
{
    [Header("View")]
    [Tooltip("True - ViewPhysics\nFalse - ViewUI")]
    [SerializeField] bool toggle;
    public ViewPhysics viewPhysics;
    public ViewUI viewUI;

    public override void InstallBindings() {
        if (toggle)
            Container.Bind<IView>().FromInstance(viewPhysics).AsSingle();
        else
            Container.Bind<IView>().FromInstance(viewUI).AsSingle();
        Container.Bind<IModel>().To<Model>().AsSingle();
    }
}
