using UnityEngine;
using System.Collections;
using ThreeDWalker;
/// <summary>
/// Function: Handle Cam Fly
/// Author: Muhammad Faizan Khan
/// </summary>
namespace ThreeDWalker
{
    public class CamFly : MonoBehaviour
    {
        [Header("Cam Fly Settings")]
        public float speed = 10;
        public float updownSpeed = 5;
        //public bool isAllowCamCollision = true;

        private GameObject camFly;
        private MovementInput objMovementInput;

        void Start()
        {
            camFly = this.transform.gameObject;
            objMovementInput = GetComponent<MovementInput>();

            // if (isAllowCamCollision)
            //{
            //     //camFly.GetComponent<BoxCollider>().isTrigger = false;
            // }
            // else { 
            //camFly.GetComponent<BoxCollider>().isTrigger = true;
            // }
        }


        void Update()
        {

            /*
            var hr = Input.GetAxis("Horizontal");

            var vr = Input.GetAxis("Vertical");

            if (Input.GetKey(KeyCode.Q))
            {
                float down = updownSpeed * Time.deltaTime *-1f;
                camFly.transform.Translate(new Vector3(hr * speed * Time.deltaTime, down, vr * Time.deltaTime * speed));
            }
            else if (Input.GetKey(KeyCode.E))
            {
                float up = updownSpeed * Time.deltaTime;
                camFly.transform.Translate(new Vector3(hr * speed * Time.deltaTime, up, vr * Time.deltaTime * speed));
            }
            else
            {
                camFly.transform.Translate(new Vector3(hr * speed * Time.deltaTime, 0, vr * Time.deltaTime * speed));
            }*/

            var hr = objMovementInput.inputHorizontal * speed * Time.deltaTime;
            var vr = objMovementInput.inputVertical * speed * Time.deltaTime;
            var upDown = objMovementInput.inputUpDown * updownSpeed * Time.deltaTime;

            camFly.transform.Translate(new Vector3(hr, upDown, vr));

        }
    }
}
