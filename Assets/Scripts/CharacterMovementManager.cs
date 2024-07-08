using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace _Joystick.Scripts
{

    public class CharacterMovementManager : MonoBehaviour
    {
        public VariableJoystick joystick;
        public CharacterController controller;
        public float movementSpeed, rotationSpeed;

        public Canvas inputCanvas;
        public bool isJoystick;

        private void Start()
        {
            EnableJoystickInput();
        }

        public void EnableJoystickInput()
        {
            isJoystick = true;
            inputCanvas.gameObject.SetActive(true);
        }

        private void Update()
        {
            if (isJoystick)
            {
                var movementDirection = new Vector3(joystick.Direction.x, 0.0f, joystick.Direction.y);
                controller.SimpleMove(movementDirection * movementSpeed);


                if (movementDirection.sqrMagnitude<=0)
                {
                    return;
                }
                var targetDirection = Vector3.RotateTowards(controller.transform.forward, movementDirection, rotationSpeed * Time.deltaTime, 0.0f);

                controller.transform.rotation = Quaternion.LookRotation(targetDirection);
            }
        }

    }
}