using UnityEngine;
using System.Collections;

public class WalkCamRotationOnMouse : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        var mouseX = Input.GetAxis("Mouse X");
        this.transform.localEulerAngles += new Vector3(0, mouseX, 0);
	}
}
