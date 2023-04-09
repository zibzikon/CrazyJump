//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public RagdollBodyListenerComponent ragdollBodyListener { get { return (RagdollBodyListenerComponent)GetComponent(GameComponentsLookup.RagdollBodyListener); } }
    public bool hasRagdollBodyListener { get { return HasComponent(GameComponentsLookup.RagdollBodyListener); } }

    public void AddRagdollBodyListener(System.Collections.Generic.List<IRagdollBodyListener> newValue) {
        var index = GameComponentsLookup.RagdollBodyListener;
        var component = (RagdollBodyListenerComponent)CreateComponent(index, typeof(RagdollBodyListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceRagdollBodyListener(System.Collections.Generic.List<IRagdollBodyListener> newValue) {
        var index = GameComponentsLookup.RagdollBodyListener;
        var component = (RagdollBodyListenerComponent)CreateComponent(index, typeof(RagdollBodyListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveRagdollBodyListener() {
        RemoveComponent(GameComponentsLookup.RagdollBodyListener);
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

    static Entitas.IMatcher<GameEntity> _matcherRagdollBodyListener;

    public static Entitas.IMatcher<GameEntity> RagdollBodyListener {
        get {
            if (_matcherRagdollBodyListener == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.RagdollBodyListener);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherRagdollBodyListener = matcher;
            }

            return _matcherRagdollBodyListener;
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

    public void AddRagdollBodyListener(IRagdollBodyListener value) {
        var listeners = hasRagdollBodyListener
            ? ragdollBodyListener.value
            : new System.Collections.Generic.List<IRagdollBodyListener>();
        listeners.Add(value);
        ReplaceRagdollBodyListener(listeners);
    }

    public void RemoveRagdollBodyListener(IRagdollBodyListener value, bool removeComponentWhenEmpty = true) {
        var listeners = ragdollBodyListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveRagdollBodyListener();
        } else {
            ReplaceRagdollBodyListener(listeners);
        }
    }
}