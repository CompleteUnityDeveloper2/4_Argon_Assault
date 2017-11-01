using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RustyBulletHoles : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnParticleCollision(GameObject other)
    {
        print("Hit " + other.name);
    }
}
