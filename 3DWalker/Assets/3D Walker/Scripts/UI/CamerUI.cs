using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using ThreeDWalker;

/// <summary>
/// Function: Handle Cam Controller object and manage its UI.
/// Author: Muhammad Faizan Khan
/// </summary>
namespace ThreeDWalker
{
    public class CamerUI : MonoBehaviour
    {
        #region Vars
        public GameObject cameraController;
        public Dropdown ddCameraSelection;
        public string ActiveCamera = "Cam Fly";
        #endregion Vars

        #region UnityEvents

        void Awake()
        {
            CameraActiveByName(ActiveCamera);
        }


        #endregion UnityEvents

        #region UIEvents

        public void OnCameraChange()
        {
            //Debug.Log(ddCameraSelection.value.ToString());
            var selectedCameraName = ddCameraSelection.options[ddCameraSelection.value].text;//Get Selected Camera
            CameraActiveByName(selectedCameraName);
        }

        #endregion UIEvents

        #region CustomMethods
        void CameraActiveByName(string cameraName)
        {
            for (int i = 0; i < cameraController.transform.childCount; i++)
            {
                if (cameraController.transform.GetChild(i).name == cameraName)
                {
                    cameraController.transform.GetChild(i).gameObject.SetActive(true);
                }
                else
                {
                    cameraController.transform.GetChild(i).gameObject.SetActive(false);
                }
            }
        }
        #endregion CustomMethods
    }
}