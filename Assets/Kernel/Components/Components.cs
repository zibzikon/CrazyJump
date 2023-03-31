using Entitas;
using Entitas.CodeGeneration.Attributes;
using Foundation;
using Kernel.GamePlay.ValuePanel;
using UnityEngine;

namespace Kernel.Components
{
    // @formatter:off

    public class ID : IComponent { [PrimaryEntityIndex] public int Value; }
    
    [Game] public class PlayerCharacter : IComponent { }
    [Game] public class ValuePanel : IComponent { }
    [Game] public class Camera : IComponent { }
    
    [Game] public class Movable : IComponent { }
    [Game] public class Collisionable : IComponent { }
    [Game] public class Interacted : IComponent { }
    [Game] public class Obtained : IComponent { }
    
    [Game] public class MovePosition : IComponent { public Vector3 Value; }
    [Game] public class FollowingOffset : IComponent { public Vector3 Value; }
    [Game] public class AccumulatedJumpForce : IComponent { public float Value; }
    [Game] public class ValuePanelFunction : IComponent { public ValuePanelFunctionType Value; }
    [Game] public class ValuePanelValue : IComponent { public float Value; }
    [Game] public class HorizontalSpeed : IComponent { public float Value; }
    [Game] public class WalkingSpeed : IComponent { public float Value; }
    [Game] public class FollowSpeed : IComponent { public float Value; }
    [Game] public class HorizontalBorder : IComponent { public RangeFloat Value; }
    
    [Game] public class CollidedEntityID: IComponent { public int Value; }
    [Game] public class FollowingEntityID: IComponent { public int Value; }

    [Unique, Input] public class Mouse : IComponent { }

    [Input] public class LeftMouse : IComponent { }
    [Input] public class RightMouse : IComponent { }
    [Input] public class HorizontalAxis : IComponent { public float Value; }
    [Input] public class VerticalAxis : IComponent { public float Value; }

    [Game, Event(EventTarget.Self)] public class Position : IComponent { public Vector3 Value; }
    [Game, Event(EventTarget.Self)] public class Rotation : IComponent { public Quaternion Value; }
}