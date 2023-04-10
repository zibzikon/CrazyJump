//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public StartedFollowingFlyingPlayerCharacterListenerComponent startedFollowingFlyingPlayerCharacterListener { get { return (StartedFollowingFlyingPlayerCharacterListenerComponent)GetComponent(GameComponentsLookup.StartedFollowingFlyingPlayerCharacterListener); } }
    public bool hasStartedFollowingFlyingPlayerCharacterListener { get { return HasComponent(GameComponentsLookup.StartedFollowingFlyingPlayerCharacterListener); } }

    public void AddStartedFollowingFlyingPlayerCharacterListener(System.Collections.Generic.List<IStartedFollowingFlyingPlayerCharacterListener> newValue) {
        var index = GameComponentsLookup.StartedFollowingFlyingPlayerCharacterListener;
        var component = (StartedFollowingFlyingPlayerCharacterListenerComponent)CreateComponent(index, typeof(StartedFollowingFlyingPlayerCharacterListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceStartedFollowingFlyingPlayerCharacterListener(System.Collections.Generic.List<IStartedFollowingFlyingPlayerCharacterListener> newValue) {
        var index = GameComponentsLookup.StartedFollowingFlyingPlayerCharacterListener;
        var component = (StartedFollowingFlyingPlayerCharacterListenerComponent)CreateComponent(index, typeof(StartedFollowingFlyingPlayerCharacterListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveStartedFollowingFlyingPlayerCharacterListener() {
        RemoveComponent(GameComponentsLookup.StartedFollowingFlyingPlayerCharacterListener);
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

    static Entitas.IMatcher<GameEntity> _matcherStartedFollowingFlyingPlayerCharacterListener;

    public static Entitas.IMatcher<GameEntity> StartedFollowingFlyingPlayerCharacterListener {
        get {
            if (_matcherStartedFollowingFlyingPlayerCharacterListener == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.StartedFollowingFlyingPlayerCharacterListener);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherStartedFollowingFlyingPlayerCharacterListener = matcher;
            }

            return _matcherStartedFollowingFlyingPlayerCharacterListener;
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public void AddStartedFollowingFlyingPlayerCharacterListener(IStartedFollowingFlyingPlayerCharacterListener value) {
        var listeners = hasStartedFollowingFlyingPlayerCharacterListener
            ? startedFollowingFlyingPlayerCharacterListener.value
            : new System.Collections.Generic.List<IStartedFollowingFlyingPlayerCharacterListener>();
        listeners.Add(value);
        ReplaceStartedFollowingFlyingPlayerCharacterListener(listeners);
    }

    public void RemoveStartedFollowingFlyingPlayerCharacterListener(IStartedFollowingFlyingPlayerCharacterListener value, bool removeComponentWhenEmpty = true) {
        var listeners = startedFollowingFlyingPlayerCharacterListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveStartedFollowingFlyingPlayerCharacterListener();
        } else {
            ReplaceStartedFollowingFlyingPlayerCharacterListener(listeners);
        }
    }
}