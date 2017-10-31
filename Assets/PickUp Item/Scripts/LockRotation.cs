using System.Collections;
using UnityEngine;

public class LockRotation : MonoBehaviour {

	public Transform CameraTransform;
	public float offestFromObject;

	void Update () {

		transform.localPosition = new Vector3 (0, 0, 0);
		transform.rotation = Quaternion.LookRotation (CameraTransform.position);
		transform.Translate (Vector3.forward * offestFromObject);

	}
}
