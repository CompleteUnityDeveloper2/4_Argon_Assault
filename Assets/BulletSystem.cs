using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSystem : MonoBehaviour {

    [SerializeField] GameObject explosionPrefab;
    [SerializeField] Transform parent;

    void OnParticleCollision(GameObject other)
    {
        List<ParticleCollisionEvent> collisionEvents = new List<ParticleCollisionEvent>();
        GetComponent<ParticleSystem>().GetCollisionEvents(other, collisionEvents);
        Vector3 impactPoint = collisionEvents[0].intersection;
        GameObject explosion = Instantiate(explosionPrefab, impactPoint, Quaternion.identity);
        explosion.transform.parent = parent;
    }
}
