using Entitas;
using Entitas.CodeGeneration.Attributes;
using Kernel.GamePlay.ValuePanel.Data;
using Kernel.Services;
using UnityEngine;

namespace Kernel.Components
{
    // @formatter:off
    
    public class ID : IComponent { [PrimaryEntityIndex] public int Value; }
    
    [Level, Unique] public class GenerateNewLevel : IComponent { }
    [Level] public class LevelDifficulty : IComponent { public int Value; }
    [Level] public class GameBoardConfiguration : IComponent { public Kernel.GamePlay.GameBoard.GameBoardConfiguration Value; }
    
    [Game, Unique] public class PlayingStarted : IComponent { }
    [Game] public class CreatePlayerCharacter : IComponent { }
    [Game] public class PlayerCharacterConfiguration : IComponent { public GamePlay.PlayerCharacter.PlayerCharacterConfiguration Value; }
    
    [Game] public class GameBoard : IComponent { }
    
    [Game] public class PlayerCharacter : IComponent { }
    [Game] public class ValuePanel : IComponent { }
    [Game] public class Camera : IComponent { }
    [Game] public class GameBoardEndPart : IComponent { }
    [Game] public class FollowingPlayerCharacter : IComponent { }
    
    [Game] public class Movable : IComponent { }
    [Game] public class Collisionable : IComponent { }
    [Game] public class Destroyable : IComponent { }
    [Game] public class MakingJump : IComponent { }
    [Game] public class Interacted : IComponent { }
    [Game] public class Obtained : IComponent { }
    
    
    [Game] public class Length : IComponent { public float Value; }
    
    [Game] public class MovePosition : IComponent { public Vector3 Value; }
    [Game] public class FollowingOffset : IComponent { public Vector3 Value; } 
    [Game] public class AccumulatedJumpForce : IComponent { public float Value; }
    [Game] public class ValuePanelFunction : IComponent { public ValuePanelFunctionType Value; }
    [Game] public class ValuePanelValue : IComponent { public float Value; }
    [Game] public class HorizontalSpeed : IComponent { public float Value; }
    [Game] public class WalkingSpeed : IComponent { public float Value; }
    [Game] public class FollowSpeed : IComponent { public float Value; }
    [Game] public class DirectionalForce: IComponent { public float Value; }
    [Game] public class GravityForce: IComponent { public float Value; }
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
    [Game, Event(EventTarget.Self)] public class Destroyed : IComponent { }
}