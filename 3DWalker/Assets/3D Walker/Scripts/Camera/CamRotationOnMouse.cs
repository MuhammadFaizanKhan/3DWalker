using UnityEngine;

namespace ThreeDWalker
{
    /// <summary>
    /// Function: This script will use to Rotate the camera using mouse
    /// Author: Muhammad Faizan Khan
    /// </summary>
    public class CamRotationOnMouse : MonoBehaviour
    {
        /// <summary>
        /// current camera
        /// </summary>
        private Transform camera;

        /// <summary>
        /// Rotation around the vertical axis is called yaw
        /// </summary>
        float yaw = 0.0f;

        /// <summary>
        /// Rotation around the side-to-side axis is called pitch
        /// </summary>
        float pitch = 0.0f;

        public float rotationSpeed = 500f;

        void Start()
        {
            camera = this.transform;//cashed current gameobject
        }

        void Update()
        {
            if (Input.GetMouseButton(1)) //left click detect and use cam rotation on mouse
            {
                yaw += Input.GetAxis("Mouse X") * Time.deltaTime * rotationSpeed;
                pitch -= Input.GetAxis("Mouse Y") * Time.deltaTime * rotationSpeed;
                camera.eulerAngles = new Vector3(pitch, yaw, 0.0f);
            }
        }


    }
}