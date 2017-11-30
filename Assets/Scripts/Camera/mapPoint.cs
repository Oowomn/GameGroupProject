using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mapPoint : MonoBehaviour {
	public GameObject mappoint;
	public GameObject target;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		//mappoint.transform.position.Set(target.transform.position.x,target.transform.position.y+80,target.transform.position.z);

	}
	void FixedUpdate(){
		if(target != null)
			mappoint.transform.position=new Vector3(target.transform.position.x,target.transform.position.y+80,target.transform.position.z);

	}
}
