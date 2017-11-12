using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSystem : MonoBehaviour {

    void OnParticleCollision(GameObject other)
    {
        List<ParticleCollisionEvent> collisionEvents = new List<ParticleCollisionEvent>();
        GetComponent<ParticleSystem>().GetCollisionEvents(other, collisionEvents);
        print(collisionEvents[0].intersection);
    }
}
