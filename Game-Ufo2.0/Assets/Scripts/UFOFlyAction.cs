using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public class UFOFlyAction : SSDirectors
    {
        public float gravity = -5; 

        private Vector3 startVector;

        private Vector3 gravityVector = Vector3.zero;

        private float time;

        private Vector3 currentAngle = Vector3.zero;
        private object transform;
        private bool destroy;
        private object callback;

        private UFOFlyAction() { }

        public static UFOFlyAction GetSSAction(Vector3 direction, float angle, float power)
        {
            UFOFlyAction action = CreateInstance<UFOFlyAction>();
            if (direction.x == -1)

            {
                action.startVector = Quaternion.Euler(new Vector3(0, 0, -angle)) * Vector3.left * power;
            }
            else
            {
                action.startVector = Quaternion.Euler(new Vector3(0, 0, angle)) * Vector3.right * power;
            }
            return action;
        }

        private static T CreateInstance<T>()
        {
            throw new NotImplementedException();
        }


    }
}
