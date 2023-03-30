using Entitas.CodeGeneration.Attributes;
using UnityEngine;
using static Entitas.CodeGeneration.Attributes.EventTarget;
// @formatter:off

[Game] public class PlayerCharacter { }
[Game] public class Movable { }
[Game] public class MovePosition { private Vector3 Value; }
[Game, Event(Self)] public class Position { private Vector3 Value; }
[Game, Event(Self)] public class Rotation { private Quaternion Value; }
