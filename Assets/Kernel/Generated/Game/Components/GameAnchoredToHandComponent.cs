//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly Kernel.Components.AnchoredToHand anchoredToHandComponent = new Kernel.Components.AnchoredToHand();

    public bool isAnchoredToHand {
        get { return HasComponent(GameComponentsLookup.AnchoredToHand); }
        set {
            if (value != isAnchoredToHand) {
                var index = GameComponentsLookup.AnchoredToHand;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : anchoredToHandComponent;

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

    static Entitas.IMatcher<GameEntity> _matcherAnchoredToHand;

    public static Entitas.IMatcher<GameEntity> AnchoredToHand {
        get {
            if (_matcherAnchoredToHand == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.AnchoredToHand);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherAnchoredToHand = matcher;
            }

            return _matcherAnchoredToHand;
        }
    }
}