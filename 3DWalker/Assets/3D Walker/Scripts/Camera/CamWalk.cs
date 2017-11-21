using UnityEngine;
using System.Collections;
using ThreeDWalker;

namespace ThreeDWalker
{
    /// <summary>
    /// Function: Handle Cam Walk
    /// Author: Muhammad Faizan Khan
    /// </summary>
    [RequireComponent(typeof(MovementInput))]
    public class CamWalk : MonoBehaviour
    {
        [Header("Cam Walk Settings")]
        public float speed = 10;

        private MovementInput objMovementInput;
        private GameObject camWalk;

        void Start()
        {
            objMovementInput = GetComponent<MovementInput>();
            camWalk = this.gameObject;
        }

        void Update()
        {
            var hr = objMovementInput.inputHorizontal* speed * Time.deltaTime; 
            var vr = objMovementInput.inputVertical* speed * Time.deltaTime;

            camWalk.transform.Translate(hr, 0, vr);
        }
    }
}
