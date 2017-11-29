using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toggledisplay : MonoBehaviour {
	public Camera thiscamera;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Tab)) {
			if (thiscamera.targetDisplay == 0)
				thiscamera.targetDisplay = 1;
			else if (thiscamera.targetDisplay == 1)
				thiscamera.targetDisplay = 0;
		}
	}

}
