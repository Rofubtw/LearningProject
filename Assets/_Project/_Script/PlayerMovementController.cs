using System;
using UnityEngine;


namespace LearningProject
{
    public class PlayerMovementController : MonoBehaviour
    {
        [SerializeField] FloatingJoystick joystick;
        [SerializeField] float speed;
        [SerializeField] float zSpeed;
        
        float Horizontal => joystick.Horizontal;
        
        void Update()
        {
            SetMovement();
        }

        void SetMovement()
        {
            var movementVector = new Vector2(Horizontal, transform.position.y);
            transform.Translate(new Vector3(movementVector.x, movementVector.y, zSpeed) * (speed * Time.deltaTime));
        }
        
    }
}

