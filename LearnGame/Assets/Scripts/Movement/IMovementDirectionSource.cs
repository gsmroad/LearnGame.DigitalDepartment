using UnityEngine;

namespace LearnGame
{
    public interface IMovementDirectionSource
    {
        Vector3 MovementDirection { get; }
    }
}