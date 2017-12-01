using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toggledisplay : MonoBehaviour {
	public Camera thiscamera;
	public KeyCode inputCode;
	private Camera[] CameraList;
	//private Camera MainCamera;
	// Use this for initialization
	void Start () {
		CameraList = Camera.allCameras;

	}

	// Update is called once per frame
	void Update () {


		if (Input.GetKeyDown (inputCode)) {

			if (thiscamera.targetDisplay == 0)
				thiscamera.targetDisplay = 1;
			else if (thiscamera.targetDisplay == 1)
				thiscamera.targetDisplay = 0;

			if (thiscamera.targetDisplay == 0) {
				for (int i = 0; i < CameraList.Length; i++) {
					CameraList [i].targetDisplay = 1;
				}
				GameObject.FindGameObjectWithTag ("MainCamera").GetComponent<Camera>().targetDisplay = 1;

				thiscamera.targetDisplay = 0;
			} else {
				for (int i = 0; i < CameraList.Length; i++) {
					CameraList [i].targetDisplay = 1;
				}
				GameObject.FindGameObjectWithTag ("MainCamera").GetComponent<Camera>().targetDisplay = 0;

				//thiscamera.targetDisplay = 0;
			}







		}


	}

}

