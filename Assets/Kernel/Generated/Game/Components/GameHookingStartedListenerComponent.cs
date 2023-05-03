//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public HookingStartedListenerComponent hookingStartedListener { get { return (HookingStartedListenerComponent)GetComponent(GameComponentsLookup.HookingStartedListener); } }
    public bool hasHookingStartedListener { get { return HasComponent(GameComponentsLookup.HookingStartedListener); } }

    public void AddHookingStartedListener(System.Collections.Generic.List<IHookingStartedListener> newValue) {
        var index = GameComponentsLookup.HookingStartedListener;
        var component = (HookingStartedListenerComponent)CreateComponent(index, typeof(HookingStartedListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceHookingStartedListener(System.Collections.Generic.List<IHookingStartedListener> newValue) {
        var index = GameComponentsLookup.HookingStartedListener;
        var component = (HookingStartedListenerComponent)CreateComponent(index, typeof(HookingStartedListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveHookingStartedListener() {
        RemoveComponent(GameComponentsLookup.HookingStartedListener);
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

    static Entitas.IMatcher<GameEntity> _matcherHookingStartedListener;

    public static Entitas.IMatcher<GameEntity> HookingStartedListener {
        get {
            if (_matcherHookingStartedListener == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.HookingStartedListener);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherHookingStartedListener = matcher;
            }

            return _matcherHookingStartedListener;
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

    public void AddHookingStartedListener(IHookingStartedListener value) {
        var listeners = hasHookingStartedListener
            ? hookingStartedListener.value
            : new System.Collections.Generic.List<IHookingStartedListener>();
        listeners.Add(value);
        ReplaceHookingStartedListener(listeners);
    }

    public void RemoveHookingStartedListener(IHookingStartedListener value, bool removeComponentWhenEmpty = true) {
        var listeners = hookingStartedListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveHookingStartedListener();
        } else {
            ReplaceHookingStartedListener(listeners);
        }
    }
}