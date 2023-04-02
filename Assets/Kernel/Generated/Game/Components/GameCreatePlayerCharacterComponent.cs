//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly Kernel.Components.CreatePlayerCharacter createPlayerCharacterComponent = new Kernel.Components.CreatePlayerCharacter();

    public bool isCreatePlayerCharacter {
        get { return HasComponent(GameComponentsLookup.CreatePlayerCharacter); }
        set {
            if (value != isCreatePlayerCharacter) {
                var index = GameComponentsLookup.CreatePlayerCharacter;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : createPlayerCharacterComponent;

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

    static Entitas.IMatcher<GameEntity> _matcherCreatePlayerCharacter;

    public static Entitas.IMatcher<GameEntity> CreatePlayerCharacter {
        get {
            if (_matcherCreatePlayerCharacter == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.CreatePlayerCharacter);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherCreatePlayerCharacter = matcher;
            }

            return _matcherCreatePlayerCharacter;
        }
    }
}