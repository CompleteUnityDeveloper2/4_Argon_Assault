using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    [SerializeField] GameObject deathFX;
    [SerializeField] Transform parent;

    ScoreBoard scoreBoard;

	// Use this for initialization
	void Start ()
    {
        scoreBoard = FindObjectOfType<ScoreBoard>();
        AddBoxCollider();
    }

    private void AddBoxCollider()
    {
        Collider boxCollider = gameObject.AddComponent<BoxCollider>();
        boxCollider.isTrigger = false;
    }

    void OnParticleCollision(GameObject other)
    {
        scoreBoard.ScoreHit();
        GameObject fx = Instantiate(deathFX, transform.position, Quaternion.identity);
        fx.transform.parent = parent;
        Destroy(gameObject); 
    }
}
