//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Kernel.Components.FollowingEntityID followingEntityID { get { return (Kernel.Components.FollowingEntityID)GetComponent(GameComponentsLookup.FollowingEntityID); } }
    public bool hasFollowingEntityID { get { return HasComponent(GameComponentsLookup.FollowingEntityID); } }

    public void AddFollowingEntityID(int newValue) {
        var index = GameComponentsLookup.FollowingEntityID;
        var component = (Kernel.Components.FollowingEntityID)CreateComponent(index, typeof(Kernel.Components.FollowingEntityID));
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceFollowingEntityID(int newValue) {
        var index = GameComponentsLookup.FollowingEntityID;
        var component = (Kernel.Components.FollowingEntityID)CreateComponent(index, typeof(Kernel.Components.FollowingEntityID));
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveFollowingEntityID() {
        RemoveComponent(GameComponentsLookup.FollowingEntityID);
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

    static Entitas.IMatcher<GameEntity> _matcherFollowingEntityID;

    public static Entitas.IMatcher<GameEntity> FollowingEntityID {
        get {
            if (_matcherFollowingEntityID == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.FollowingEntityID);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherFollowingEntityID = matcher;
            }

            return _matcherFollowingEntityID;
        }
    }
}
