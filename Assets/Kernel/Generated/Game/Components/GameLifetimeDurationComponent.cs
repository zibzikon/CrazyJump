//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly Kernel.Components.LifetimeDuration lifetimeDurationComponent = new Kernel.Components.LifetimeDuration();

    public bool isLifetimeDuration {
        get { return HasComponent(GameComponentsLookup.LifetimeDuration); }
        set {
            if (value != isLifetimeDuration) {
                var index = GameComponentsLookup.LifetimeDuration;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : lifetimeDurationComponent;

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

    static Entitas.IMatcher<GameEntity> _matcherLifetimeDuration;

    public static Entitas.IMatcher<GameEntity> LifetimeDuration {
        get {
            if (_matcherLifetimeDuration == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.LifetimeDuration);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherLifetimeDuration = matcher;
            }

            return _matcherLifetimeDuration;
        }
    }
}