//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly Kernel.Components.Obtained obtainedComponent = new Kernel.Components.Obtained();

    public bool isObtained {
        get { return HasComponent(GameComponentsLookup.Obtained); }
        set {
            if (value != isObtained) {
                var index = GameComponentsLookup.Obtained;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : obtainedComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
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

    static Entitas.IMatcher<GameEntity> _matcherObtained;

    public static Entitas.IMatcher<GameEntity> Obtained {
        get {
            if (_matcherObtained == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Obtained);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherObtained = matcher;
            }

            return _matcherObtained;
        }
    }
}
