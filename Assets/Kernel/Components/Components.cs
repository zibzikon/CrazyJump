using  Entitas;
using Entitas.CodeGeneration.Attributes;
using Kernel.GamePlay.ValuePanel.Data;
using Kernel.Services;
using UnityEngine;
using static Entitas.CodeGeneration.Attributes.EventTarget;

namespace Kernel.Components
{
    // @formatter:off
    
    public class ID : IComponent { [PrimaryEntityIndex] public int Value; }
   
    
    [Level, Unique] public class GenerateNewLevel : IComponent { }
    [Level] public class LevelDifficulty : IComponent { public int Value; }
    [Level] public class GameBoardConfiguration : IComponent { public Kernel.GamePlay.GameBoard.GameBoardConfiguration Value; }
    [Level] public class CreatePlayerCharacter : IComponent { }
    [Level] public class PlayerCharacterConfiguration : IComponent { public GamePlay.PlayerCharacter.PlayerCharacterConfiguration Value; }
    
    [Game, Unique] public class PlayingStarted : IComponent { }
    
    [Game, Unique] public class GameLose : IComponent { }
    
    [Game, Unique] public class GravityForce: IComponent { public float Value; }
    
    [Game] public class GameBoard : IComponent { }
    
    [Game] public class PlayerCharacter : IComponent { }
    [Game] public class ValuePanel : IComponent { }
    [Game] public class Camera : IComponent { }
    [Game] public class GameBoardEndPart : IComponent { }
    [Game] public class HeightsDiapason : IComponent { }
    [Game] public class HeightsDiapasonRow : IComponent { }
    [Game] public class FollowingPlayerCharacter : IComponent { }
    
    [Game] public class Movable : IComponent { }
    [Game] public class Collisionable : IComponent { }
    [Game] public class Destructable : IComponent { }
    
    [Game] public class Interacted : IComponent { }
    [Game] public class Obtained : IComponent { }
    [Game] public class Hooked : IComponent { }
    [Game] public class DurationUp : IComponent { }
    [Game] public class LifetimeDuration : IComponent { }
    
    [Game] public class Duration : IComponent { public float Value; }
    [Game] public class DurationLeft : IComponent { public float Value; }
    [Game] public class HookingProcessDuration : IComponent { public float Value; }
    [Game] public class DisappearingDuration : IComponent { public float Value; }
    [Game] public class Length : IComponent { public float Value; }
    [Game] public class MovePosition : IComponent { public Vector3 Value; }
    [Game] public class DefaultRotation : IComponent { public Vector3 Value; }
    [Game] public class HookedEntityID : IComponent { public int Value; }
    [Game] public class MovingDirection : IComponent { public Vector3 Value; }
    [Game] public class TargetRotation : IComponent { public Vector3 Value; }
    [Game] public class FollowingOffset : IComponent { public Vector3 Value; }
    [Game] public class RotationSensitivity : IComponent { public float Value; }
    [Game] public class AccumulatedJumpForce : IComponent { public float Value; }
    [Game] public class ValuePanelFunction : IComponent { public MathematicalFunctionType Value; }
    [Game] public class ValuePanelValue : IComponent { public float Value; }
    [Game] public class HorizontalSpeed : IComponent { public float Value; }
    [Game] public class RunningSpeed : IComponent { public float Value; }
    [Game] public class FollowSpeed : IComponent { public float Value; }
    [Game] public class DirectionalForce: IComponent { public float Value; }
    [Game] public class MaxHeight : IComponent { public float Value; }
    [Game] public class RowsCount : IComponent { public int Value; }
    [Game] public class RowPosition : IComponent { public int Value; }
    [Game] public class Height : IComponent { public float Value; }
    [Game] public class HorizontalBorder : IComponent { public RangeFloat Value; }
    [Game] public class RotationYBorder : IComponent { public RangeFloat Value; }

    [Game] public class CollidedEntityID: IComponent { public int Value; }
    [Game] public class FollowingEntityID: IComponent { public int Value; }

    [Unique, Input] public class Mouse : IComponent { }
    [Input] public class LeftMouse : IComponent { }
    [Input] public class RightMouse : IComponent { }

    [Input] public class HorizontalAxis : IComponent { public float Value; }
    [Input] public class VerticalAxis : IComponent { public float Value; }

    [Game, Event(Self)] public class RagdollBody : IComponent { }
    [Game, Event(Self)] public class MakingJump : IComponent { }
    [Game, Event(Self)] public class Destructed : IComponent { }
    [Game, Event(Self)] public class Running : IComponent { }
    [Game, Event(Self)] public class HookingStarted : IComponent { }
    [Game, Event(Self)] public class DisappearingStarted : IComponent { }
    [Game, Event(Self)] public class AnchoredToHand : IComponent { }
    [Game, Event(Self)] public class Position : IComponent { public Vector3 Value; }
    [Game, Event(Self)] public class StartedFollowingFlyingPlayerCharacter : IComponent { }
    [Game, Event(Self)] public class Rotation : IComponent { public Vector3 Value; }

}
