using UnityEngine;
using System.Collections;
using ThreeDWalker;
namespace ThreeDWalker
{
    [RequireComponent(typeof(MovementInput))]
    public class CamWalk : MonoBehaviour
    {

        private MovementInput objMovementInput;
        private GameObject camWalk;

        void Start()
        {
            objMovementInput = GetComponent<MovementInput>();
            camWalk = this.gameObject;
        }

        void Update()
        {
            camWalk.transform.Rotate(0f, objMovementInput.inputHorizontal, 0f);
        }
    }
}
