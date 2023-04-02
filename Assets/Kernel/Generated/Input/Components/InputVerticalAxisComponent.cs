//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class InputEntity {

    public Kernel.Components.VerticalAxis verticalAxis { get { return (Kernel.Components.VerticalAxis)GetComponent(InputComponentsLookup.VerticalAxis); } }
    public bool hasVerticalAxis { get { return HasComponent(InputComponentsLookup.VerticalAxis); } }

    public void AddVerticalAxis(float newValue) {
        var index = InputComponentsLookup.VerticalAxis;
        var component = (Kernel.Components.VerticalAxis)CreateComponent(index, typeof(Kernel.Components.VerticalAxis));
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceVerticalAxis(float newValue) {
        var index = InputComponentsLookup.VerticalAxis;
        var component = (Kernel.Components.VerticalAxis)CreateComponent(index, typeof(Kernel.Components.VerticalAxis));
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveVerticalAxis() {
        RemoveComponent(InputComponentsLookup.VerticalAxis);
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
public sealed partial class InputMatcher {

    static Entitas.IMatcher<InputEntity> _matcherVerticalAxis;

    public static Entitas.IMatcher<InputEntity> VerticalAxis {
        get {
            if (_matcherVerticalAxis == null) {
                var matcher = (Entitas.Matcher<InputEntity>)Entitas.Matcher<InputEntity>.AllOf(InputComponentsLookup.VerticalAxis);
                matcher.componentNames = InputComponentsLookup.componentNames;
                _matcherVerticalAxis = matcher;
            }

            return _matcherVerticalAxis;
        }
    }
}
