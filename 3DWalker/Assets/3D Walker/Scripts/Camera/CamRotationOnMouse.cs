using UnityEngine;

namespace ThreeDWalker
{
    /// <summary>
    /// Function: This script will use to Rotate the camera using mouse
    /// Author: Muhammad Faizan Khan
    /// </summary>
    public class CamRotationOnMouse : MonoBehaviour
    {
        private Transform camera;
        float yaw = 0.0f; // Rotation around the vertical axis is called yaw
        float pitch = 0.0f;//Rotation around the side-to-side axis is called pitch

        public float rotationSpeed = 2f;

        void Start()
        {
            camera = this.transform;
        }

        void Update()
        {
            if (Input.GetMouseButton(1))
            {
                yaw += Input.GetAxis("Mouse X") * Time.deltaTime * rotationSpeed;
                pitch -= Input.GetAxis("Mouse Y") * Time.deltaTime * rotationSpeed;
                camera.eulerAngles = new Vector3(pitch, yaw, 0.0f);
            }
        }


    }
}