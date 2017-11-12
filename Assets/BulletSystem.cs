using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSystem : MonoBehaviour {

    void OnParticleCollision(GameObject other)
    {
        print(other);
    }
}
