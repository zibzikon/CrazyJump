//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly Kernel.Components.GameBoard gameBoardComponent = new Kernel.Components.GameBoard();

    public bool isGameBoard {
        get { return HasComponent(GameComponentsLookup.GameBoard); }
        set {
            if (value != isGameBoard) {
                var index = GameComponentsLookup.GameBoard;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : gameBoardComponent;

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

    static Entitas.IMatcher<GameEntity> _matcherGameBoard;

    public static Entitas.IMatcher<GameEntity> GameBoard {
        get {
            if (_matcherGameBoard == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.GameBoard);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherGameBoard = matcher;
            }

            return _matcherGameBoard;
        }
    }
}