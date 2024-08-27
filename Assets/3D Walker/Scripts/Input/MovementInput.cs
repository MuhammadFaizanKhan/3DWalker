using UnityEngine;
using System.Collections;
using ThreeDWalker;


namespace ThreeDWalker
{
    /// <summary>
    /// Function: Handle Keyboard Input
    /// Author: Muhammad Faizan Khan
    /// </summary>
    public class MovementInput : MonoBehaviour
    {
        [HideInInspector]
        public float inputHorizontal;

        [HideInInspector]
        public float inputVertical;

        [HideInInspector]
        public float inputUpDown;

        private float upDownFactor = 5;


        void Update()
        {

            inputHorizontal = Input.GetAxis("Horizontal");
            inputVertical = Input.GetAxis("Vertical");

            if (Input.GetKey(KeyCode.Q))
            {
                inputUpDown = Time.deltaTime * -1f * upDownFactor;

            }
            else if (Input.GetKey(KeyCode.E))
            {
                inputUpDown = Time.deltaTime * 1f * upDownFactor;
            }
        }
    }
}