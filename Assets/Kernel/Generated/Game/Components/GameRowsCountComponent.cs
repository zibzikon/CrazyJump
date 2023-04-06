//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Kernel.Components.RowsCount rowsCount { get { return (Kernel.Components.RowsCount)GetComponent(GameComponentsLookup.RowsCount); } }
    public bool hasRowsCount { get { return HasComponent(GameComponentsLookup.RowsCount); } }

    public void AddRowsCount(int newValue) {
        var index = GameComponentsLookup.RowsCount;
        var component = (Kernel.Components.RowsCount)CreateComponent(index, typeof(Kernel.Components.RowsCount));
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceRowsCount(int newValue) {
        var index = GameComponentsLookup.RowsCount;
        var component = (Kernel.Components.RowsCount)CreateComponent(index, typeof(Kernel.Components.RowsCount));
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveRowsCount() {
        RemoveComponent(GameComponentsLookup.RowsCount);
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

    static Entitas.IMatcher<GameEntity> _matcherRowsCount;

    public static Entitas.IMatcher<GameEntity> RowsCount {
        get {
            if (_matcherRowsCount == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.RowsCount);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherRowsCount = matcher;
            }

            return _matcherRowsCount;
        }
    }
}
