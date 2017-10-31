using System.Collections;
using UnityEngine;

public class RotateOnY : MonoBehaviour {

	public float RotationSpeed ;

	void Update () {
		transform.Rotate (new Vector3 (0,RotationSpeed,0));
	}
}
