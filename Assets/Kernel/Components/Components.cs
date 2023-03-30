using Entitas;
using Entitas.CodeGeneration.Attributes;
using UnityEngine;
using static Entitas.CodeGeneration.Attributes.EventTarget;
// @formatter:off

[Game] public class PlayerCharacter : IComponent { }
[Game] public class Movable : IComponent { }
[Game] public class MovePosition : IComponent { private Vector3 Value; }
[Game, Event(Self)] public class Position : IComponent { private Vector3 Value; }
[Game, Event(Self)] public class Rotation : IComponent { private Quaternion Value; }
