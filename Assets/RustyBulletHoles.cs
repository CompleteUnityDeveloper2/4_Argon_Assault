using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RustyBulletHoles : MonoBehaviour {

    [SerializeField] GameObject boom;
    public List<ParticleCollisionEvent> collisionEvents;

    ParticleSystem part;

	// Use this for initialization
	void Start () {
        collisionEvents = new List<ParticleCollisionEvent>();
        part = GetComponent<ParticleSystem>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnParticleCollision(GameObject other)
    {
        part.GetCollisionEvents(other, collisionEvents);

        Vector3 impactPoint = collisionEvents[0].intersection;
        Instantiate(boom, impactPoint, Quaternion.identity);
    }
}
