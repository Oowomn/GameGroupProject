using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTank : MonoBehaviour {

    Vector3 tankLastPos;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        GameObject obj = GameObject.Find("CompleteTank(Clone)");
        if(obj != null)
        {
            tankLastPos = obj.transform.position;
            transform.position = obj.transform.position + new Vector3(0, 5, 5) + new Vector3(0, Time.deltaTime, Time.deltaTime);
            GetComponent<Camera>().transform.LookAt(obj.transform);
        }
        else
        {
            transform.position = tankLastPos + new Vector3(0, 10, 10) + new Vector3(0, 2* Time.deltaTime,2* Time.deltaTime);
        }
            
	}
}
