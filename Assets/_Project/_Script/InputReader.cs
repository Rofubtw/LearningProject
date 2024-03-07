using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

namespace LearningProject
{
    public class InputReader : ScriptableObject, PlayerInputActions.IPlayerActions
    {
        public event UnityAction<Vector2> Move = delegate { };

        PlayerInputActions inputActions;
        
        public Vector3 Direction => inputActions.Player.Move.ReadValue<Vector2>();

        void OnEnable()
        {
            if (inputActions == null)
            {
                inputActions = new PlayerInputActions();
                inputActions.Player.SetCallbacks(this);
            }
            inputActions.Enable();
        }

        public void OnMove(InputAction.CallbackContext context)
        {
            Move.Invoke(context.ReadValue<Vector2>());
        }

        public void OnLook(InputAction.CallbackContext context)
        {
            // noop
        }

        public void OnFire(InputAction.CallbackContext context)
        {
            // noop
        }
    }
}
