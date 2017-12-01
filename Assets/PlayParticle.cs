using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayParticle : MonoBehaviour {

	// Use this for initialization
	void Start () {
        ParticleSystem[] m_particleSystems = GetComponentsInChildren<ParticleSystem>();
        for (int i = 0; i < m_particleSystems.Length; ++i)
        {
            m_particleSystems[i].Play();
        }
    }
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(0, 1, 0));
	}
}
