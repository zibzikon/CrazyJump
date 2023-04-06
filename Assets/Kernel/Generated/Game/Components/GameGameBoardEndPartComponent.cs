//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly Kernel.Components.GameBoardEndPart gameBoardEndPartComponent = new Kernel.Components.GameBoardEndPart();

    public bool isGameBoardEndPart {
        get { return HasComponent(GameComponentsLookup.GameBoardEndPart); }
        set {
            if (value != isGameBoardEndPart) {
                var index = GameComponentsLookup.GameBoardEndPart;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : gameBoardEndPartComponent;

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

    static Entitas.IMatcher<GameEntity> _matcherGameBoardEndPart;

    public static Entitas.IMatcher<GameEntity> GameBoardEndPart {
        get {
            if (_matcherGameBoardEndPart == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.GameBoardEndPart);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherGameBoardEndPart = matcher;
            }

            return _matcherGameBoardEndPart;
        }
    }
}