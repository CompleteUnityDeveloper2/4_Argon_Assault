using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour {

    [Tooltip("In seconds")][SerializeField] float destroyDelay = 10f;

	// Use this for initialization
	void Start () {
        Destroy(gameObject, destroyDelay);
	}
}
