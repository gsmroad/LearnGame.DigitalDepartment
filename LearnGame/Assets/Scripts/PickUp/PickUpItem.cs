using LearnGame.Shooting;
using System;
using UnityEngine;

namespace LearnGame.PickUp
{
    public class PickUpItem : MonoBehaviour
    {
        public event Action<PickUpItem> OnPickedUp;

        public virtual void PickUp(BaseCharacter character)
        {
            OnPickedUp?.Invoke(this);
        }
    }
}