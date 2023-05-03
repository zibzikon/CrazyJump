//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public RunningListenerComponent runningListener { get { return (RunningListenerComponent)GetComponent(GameComponentsLookup.RunningListener); } }
    public bool hasRunningListener { get { return HasComponent(GameComponentsLookup.RunningListener); } }

    public void AddRunningListener(System.Collections.Generic.List<IRunningListener> newValue) {
        var index = GameComponentsLookup.RunningListener;
        var component = (RunningListenerComponent)CreateComponent(index, typeof(RunningListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceRunningListener(System.Collections.Generic.List<IRunningListener> newValue) {
        var index = GameComponentsLookup.RunningListener;
        var component = (RunningListenerComponent)CreateComponent(index, typeof(RunningListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveRunningListener() {
        RemoveComponent(GameComponentsLookup.RunningListener);
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

    static Entitas.IMatcher<GameEntity> _matcherRunningListener;

    public static Entitas.IMatcher<GameEntity> RunningListener {
        get {
            if (_matcherRunningListener == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.RunningListener);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherRunningListener = matcher;
            }

            return _matcherRunningListener;
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

    public void AddRunningListener(IRunningListener value) {
        var listeners = hasRunningListener
            ? runningListener.value
            : new System.Collections.Generic.List<IRunningListener>();
        listeners.Add(value);
        ReplaceRunningListener(listeners);
    }

    public void RemoveRunningListener(IRunningListener value, bool removeComponentWhenEmpty = true) {
        var listeners = runningListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveRunningListener();
        } else {
            ReplaceRunningListener(listeners);
        }
    }
}