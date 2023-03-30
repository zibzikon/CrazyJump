using System.Collections;
using System.Collections.Generic;
using Kernel;
using UnityEngine;
using Zenject;

public class BootstrapInstaller : MonoInstaller
{
    [SerializeField] private Bootstrap _bootstrap;

    public override void InstallBindings()
    {
        Container.BindInstance(_bootstrap).AsSingle();
    }
}