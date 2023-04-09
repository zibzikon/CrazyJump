//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Kernel.Components.TargetRotation targetRotation { get { return (Kernel.Components.TargetRotation)GetComponent(GameComponentsLookup.TargetRotation); } }
    public bool hasTargetRotation { get { return HasComponent(GameComponentsLookup.TargetRotation); } }

    public void AddTargetRotation(UnityEngine.Vector3 newValue) {
        var index = GameComponentsLookup.TargetRotation;
        var component = (Kernel.Components.TargetRotation)CreateComponent(index, typeof(Kernel.Components.TargetRotation));
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceTargetRotation(UnityEngine.Vector3 newValue) {
        var index = GameComponentsLookup.TargetRotation;
        var component = (Kernel.Components.TargetRotation)CreateComponent(index, typeof(Kernel.Components.TargetRotation));
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveTargetRotation() {
        RemoveComponent(GameComponentsLookup.TargetRotation);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherTargetRotation;

    public static Entitas.IMatcher<GameEntity> TargetRotation {
        get {
            if (_matcherTargetRotation == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.TargetRotation);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherTargetRotation = matcher;
            }

            return _matcherTargetRotation;
        }
    }
}
