using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : MonoBehaviour {

    public GameObject map1;
    public GameObject map2;

    public AudioSource map1BG;
    public AudioSource map2BG;

    int map;

	// Use this for initialization
	void Awake () {
        map = PlayerPrefs.GetInt("map");
        map1.SetActive(map == 1);
        map2.SetActive(map == 2);
        map1BG.enabled = (map == 1);
        map2BG.enabled = (map == 2);


    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
