using UnityEngine;

namespace ThreeDWalker
{
    /// <summary>
    /// Function: This script will use to Rotate the Walk Camera using mouse right click 
    /// Author: Muhammad Faizan Khan
    /// </summary>
    public class WalkCamRotationOnMouse : MonoBehaviour
    {
        /// <summary>
        /// Head Object in Walk Camera
        /// </summary>
        GameObject walkCamHead;

        /// <summary>
        /// Head Object in Walk Camera
        /// </summary>
        GameObject walkCamBody;

        public float rotationSpeed = 500f;

        void Start()
        {
            walkCamBody = this.transform.gameObject;//Get the Walk cam Body
            walkCamHead = this.transform.GetChild(0).gameObject;//Get the Walk cam head (child object)
            Debug.Log("walk camera" + walkCamHead.name);
        }

        void Update()
        {
            if (Input.GetMouseButton(1)) //left click detect and use cam rotation on mouse
            {
                var mouseX = Input.GetAxis("Mouse X");
                walkCamBody.transform.localEulerAngles += new Vector3(0f, mouseX * rotationSpeed * Time.deltaTime, 0f);

                var mouseY = Input.GetAxis("Mouse Y");
                walkCamHead.transform.localEulerAngles -= new Vector3(mouseY * rotationSpeed * Time.deltaTime, 0f, 0f);
            }
        }
    }
}
